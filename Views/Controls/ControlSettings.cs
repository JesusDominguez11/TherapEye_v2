using System;
using System.Drawing;
using System.Windows.Forms;
using Therapheye.Views.Forms;
using Therapheye.Views.Forms.Filters;

namespace Therapheye.Views.Controls
{
    public partial class ControlSettings : UserControl
    {
        #region GLOBAL VARIABLES ------------------------------------------------------------------------------------

        private ScreenFilter DarkScreenFilter;
        private ScreenFilter BlueLightScreenFilter;
        private ScreenFilter StenopeicScreenFilter;

        #endregion --------------------------------------------------------------------------------------------------



        public ControlSettings()
        {
            InitializeComponent();
        }



        #region DARKSCREENFILTER ------------------------------------------------------------------------------------
        private void ckbDarkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDarkFilter.Checked == true)
            {
                tbDarkFilter.Enabled = true;
                DarkScreenFilter = new DarkScreen();
                DarkScreenFilter.Show();

                cmsScreenFilters.Items[0].Enabled = true;
            }
            else if (ckbDarkFilter.Checked == false)
            {
                tbDarkFilter.Enabled = false;
                tbDarkFilter.Value = 1;

                if (DarkScreenFilter != null)
                {
                    cmsScreenFilters.Items[0].Enabled = false;

                    DarkScreenFilter.Close();
                }
            }
        }

        private void tbDarkFilter_Scroll(object sender, EventArgs e)
        {
            double customOpacity = Convert.ToDouble(0.04 * (Convert.ToDouble(tbDarkFilter.Value)));
            DarkScreenFilter.filterOpacity = customOpacity;
            DarkScreenFilter.Refresh();
        }



        #endregion --------------------------------------------------------------------------------------------------





        #region BLUELIGHTFILTER -------------------------------------------------------------------------------------

        private void ckbBlueFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBlueFilter.Checked == true)
            {
                tbBlueFilter.Enabled = true;
                BlueLightScreenFilter = new BlueLight();
                BlueLightScreenFilter.Show();

                cmsScreenFilters.Items[1].Enabled = true;
            }
            else if (ckbBlueFilter.Checked == false)
            {
                tbBlueFilter.Enabled = false;
                tbBlueFilter.Value = 1;

                if (BlueLightScreenFilter != null)
                {
                    cmsScreenFilters.Items[1].Enabled = false;

                    BlueLightScreenFilter.Close();
                }
            }
        }

        private void tbBlueFilter_Scroll(object sender, EventArgs e)
        {
            double customOpacity = Convert.ToDouble(0.04 * (Convert.ToDouble(tbBlueFilter.Value)));
            BlueLightScreenFilter.filterOpacity = customOpacity;
            BlueLightScreenFilter.Refresh();
        }

        #endregion --------------------------------------------------------------------------------------------------





        #region STENOPEICSCREENFILTER -------------------------------------------------------------------------------
        
        private void ckbStenopeicFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStenopeicFilter.Checked == true)
            {
                cmbStenopeicType.Enabled = true;
                cmbStenopeicType.SelectedIndex = 0;

                cmsScreenFilters.Items[2].Enabled = true;
            }
            else if (ckbStenopeicFilter.Checked == false)
            {
                cmbStenopeicType.SelectedIndex = -1;
                cmbStenopeicType.Enabled = false;

                cmsScreenFilters.Items[2].Enabled = false;
            }
        }

        private void cmbStenopeicType_SelectedChanged(object sender, EventArgs e)
        {
            // Comprueba si realmente cambió el índice seleccionado
            if (cmbStenopeicType.SelectedIndex != cmbStenopeicType.Tag as int?)
            {
                // Guarda el nuevo índice como referencia para la próxima vez
                cmbStenopeicType.Tag = cmbStenopeicType.SelectedIndex;

                ControllerStenopeicScreenFilter();
            }
        }

        private void ControllerStenopeicScreenFilter()
        {
            string StenopeicType = Convert.ToString(cmbStenopeicType.SelectedItem);

            if (StenopeicType == "")
            {
                if (StenopeicScreenFilter != null)
                {
                    ControllerStenopeicSetting(false);

                    StenopeicScreenFilter.Close();

                    return;
                }
            }else
            {
                ControllerStenopeicSetting(true);

                SingletonStenopeicScreenFilter(StenopeicType).Show(); 
            }
        }

        private ScreenFilter SingletonStenopeicScreenFilter(string StenopeicType)
        {
            bool toSetup = false;

            if (StenopeicScreenFilter != null)
            {
                StenopeicScreenFilter.Close();

                toSetup = true;
            }

            switch (StenopeicType)
            {
                case "Circular":
                    {
                        StenopeicScreenFilter = new CircularStenopeic();
                    }
                    break;
                case "Triangular":
                    {
                        StenopeicScreenFilter = new TriangularStenopeic();
                    }
                    break;
                case "Hexagonal":
                    {
                        StenopeicScreenFilter = new HexagonalStenopeic();
                    }
                    break;
            }

            if (toSetup == true)
            {
                SetupStenopeicFilter();
            }

            return StenopeicScreenFilter;
        }

        private void ControllerStenopeicSetting(bool active)
        {
            if (active)
            {
                tbStenopeicFilter.Enabled = true;
                tbApertureSize.Enabled = true;
                tbApertureSpacing.Enabled = true;
                btnChangeColor.Enabled = true;
                picBoxColor.Enabled = true;
            }
            else if (!active)
            {
                tbStenopeicFilter.Value = 1;
                tbStenopeicFilter.Enabled = false;
                tbApertureSize.Value = 1;
                tbApertureSize.Enabled = false;
                tbApertureSpacing.Value = 1;
                tbApertureSpacing.Enabled = false;
                btnChangeColor.Enabled = false;
                picBoxColor.Enabled = false;
                picBoxColor.BackColor = Color.Gainsboro;
            }
        }

        private void SetupStenopeicFilter()
        {
            StenopeicScreenFilter.filterColor = colDlgStenopeicFilter.Color;
            tbStenopeicFilter_Scroll(tbStenopeicFilter, EventArgs.Empty);
            tbApertureSize_Scroll(tbApertureSize, EventArgs.Empty);
            tbApertureSpacing_Scroll(tbApertureSpacing, EventArgs.Empty);
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colDlgStenopeicFilter.ShowDialog();
            Color colorBackground = colDlgStenopeicFilter.Color;
            picBoxColor.BackColor = colorBackground;
            StenopeicScreenFilter.filterColor = colorBackground;
            //StenopeicScreenFilter.Update();
            StenopeicScreenFilter.Refresh();
        }

        private void tbStenopeicFilter_Scroll(object sender, EventArgs e)
        {
            double customOpacity = Convert.ToDouble(0.04 * (Convert.ToDouble(tbStenopeicFilter.Value)));
            StenopeicScreenFilter.filterOpacity = customOpacity;
            StenopeicScreenFilter.Refresh();
        }

        private void tbApertureSize_Scroll(object sender, EventArgs e)
        {
            int customApertureSize = Convert.ToInt32(5 * (Convert.ToDouble(tbApertureSize.Value)));
            StenopeicScreenFilter.apertureSize = customApertureSize;
            StenopeicScreenFilter.Refresh();
        }

        private void tbApertureSpacing_Scroll(object sender, EventArgs e)
        {
            int customApertureSpacing = Convert.ToInt32(10 * (Convert.ToDouble(tbApertureSpacing.Value)));
            StenopeicScreenFilter.apertureSpacing = customApertureSpacing;
            StenopeicScreenFilter.Refresh();
        }


        #endregion --------------------------------------------------------------------------------------------------

        private void tsmiDarkScreen_Click(object sender, EventArgs e)
        {
            if (DarkScreenFilter.Visible == true)
            {
                DarkScreenFilter.Visible = false;
            }
            else
            {
                DarkScreenFilter.Visible = true;
            }            
        }

        private void tsmiBlueLight_Click(object sender, EventArgs e)
        {
            if (BlueLightScreenFilter.Visible == true)
            {
                BlueLightScreenFilter.Visible = false;
            }
            else
            {
                BlueLightScreenFilter.Visible = true;
            }
        }

        private void tsmiStenopeic_Click(object sender, EventArgs e)
        {
            if (StenopeicScreenFilter.Visible == true)
            {
                StenopeicScreenFilter.Visible = false;
            }
            else
            {
                StenopeicScreenFilter.Visible = true;
            }

        }




    }
}
