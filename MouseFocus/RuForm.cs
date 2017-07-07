using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security;

using Microsoft.Win32;

namespace MouseFocus
{
    public partial class MouseFocus : Form
    {

        byte[] updatedUserPreferenceMask = { 0x9F, 0x3E, 0x07, 0x80, 0x12, 0x00, 0x00, 0x00 };
        byte[] defaultUserPreferenceMask = { 0x98, 0x12, 0x07, 0x80, 0x12, 0x00, 0x00, 0x00 };

        int updatedActiveWndTrkTimeout = 0;
        int defaultActiveWndTrkTimeout = 500;

        String keyLocation = "HKEY_CURRENT_USER\\Control Panel\\Desktop";
        String keyByteValue1 = "UserPreferenceMask";
        String keyDWRDValue2 = "ActiveWndTrkTimeout";

        public MouseFocus()
        {
            InitializeComponent();
            setStatusLabel(false);
            this.logOutWarningLabel.Text = "";
        }

        private void hoverMouseFocusButton_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(keyLocation, keyByteValue1, updatedUserPreferenceMask, RegistryValueKind.Binary);
                Registry.SetValue(keyLocation, keyDWRDValue2, updatedActiveWndTrkTimeout, RegistryValueKind.DWord);

                setStatusLabel(true);                             
            }
            catch (UnauthorizedAccessException exceptionMsg)
            {
                MessageBox.Show(exceptionMsg.ToString(), "Unauthorized access error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SecurityException exceptionMsg)
            {
                MessageBox.Show(exceptionMsg.ToString(), "Security error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clickMouseFocusButton_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(keyLocation, keyByteValue1, defaultUserPreferenceMask, RegistryValueKind.Binary);
                Registry.SetValue(keyLocation, keyDWRDValue2, defaultActiveWndTrkTimeout, RegistryValueKind.DWord);

                setStatusLabel(true);              
            }
            catch (UnauthorizedAccessException exceptionMsg)
            {
                MessageBox.Show(exceptionMsg.ToString(), "Unauthorized access error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SecurityException exceptionMsg)
            {
                MessageBox.Show(exceptionMsg.ToString(), "Security error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int getCurrentFocusStatusType()
        {
            String currentUserPreferenceMask = BitConverter.ToString((byte[])Registry.GetValue(keyLocation, keyByteValue1, null));
            String currentActiveWndTrkTimeout = Registry.GetValue(keyLocation, keyDWRDValue2, null).ToString();

            String defaultUserPreferenceMask = BitConverter.ToString(this.defaultUserPreferenceMask);
            String defaultActiveWndTrkTimeout = this.defaultActiveWndTrkTimeout.ToString();

            String updatedUserPreferenceMask = BitConverter.ToString(this.updatedUserPreferenceMask);
            String updatedActiveWndTrkTimeout = this.updatedActiveWndTrkTimeout.ToString();

            

            if (currentUserPreferenceMask == defaultUserPreferenceMask && currentActiveWndTrkTimeout == defaultActiveWndTrkTimeout)
            {
                return 0;
            }
            else if (currentUserPreferenceMask == updatedUserPreferenceMask && currentActiveWndTrkTimeout == updatedActiveWndTrkTimeout)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void setStatusLabel(bool isButtonClicked)
        {
            String focusStatus;

            switch(getCurrentFocusStatusType())
            {
                case 0:
                    focusStatus = "Mouse window focus is set to click (default)";
                    break;

                case 1:
                    focusStatus = "Mouse window focus is set to hover";
                    break;

                case 2:
                    focusStatus = "Mouse window focus is set to custom behavior." + Environment.NewLine + "Click on one of the buttons to set focus behavior.";
                    break;

                default:
                    focusStatus = "Critical error!";
                    break;
            }

            this.focusStatusLabel.Text = focusStatus;   
            
            if(isButtonClicked)
            {
                this.logOutWarningLabel.Text = "Please log out and log in for changes to take effect.";
            }
        }

    }
}
