using PianoManagementWPF.Databases;
using PianoManagementWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PianoManagementWPF.UserControls
{
    /// <summary>
    /// Logique d'interaction pour PianoUserControl.xaml
    /// </summary>
    public partial class PianoUserControl : BaseUserControl, ICrud
    {
        #region Constructors
        public PianoUserControl()
        {
            InitializeComponent();

            LoadOrReloadData();
        }

      
        #endregion

        public override void LoadOrReloadData()
        {
            DataGridContenu.ItemsSource = PianoManagementDatabase.Current.Piano.ToList();
            DataGridContenu.Items.Refresh();
        }

        public void Create()
        {
            
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
