using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PianoManagementWPF.UserControls
{
    public abstract class BaseUserControl : UserControl
    {

        public BaseUserControl()
        {

        }

        #region Virtuals

        public virtual Window CreateWindow()
        {
            throw new Exception("Fonction non implémentée");
        }

        public virtual bool AddItemInDatabase(Window window)
        {
            throw new Exception("Fonction non implémentée");
        }

        public virtual void LoadOrReloadData()
        {
            throw new Exception("Fonction non implémentée");
        }

        #endregion

        #region Funcs   

        public void Create()
        {
            Window window = CreateWindow();

            window.ShowDialog();

            if (window.DialogResult.HasValue && window.DialogResult.Value == true)
            {
                AddItemInDatabase(window);
                try
                {
                    Databases.PianoManagementDatabase.Current.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de la sauvegarde");
                    Databases.PianoManagementDatabase.ReinitializeDatabase();
                }
            }
            else
            {
                Databases.PianoManagementDatabase.ReinitializeDatabase();
            }

            LoadOrReloadData();

        }      


        #endregion
    }
}
