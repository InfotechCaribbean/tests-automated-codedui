namespace Functional_Tests.resources.CommonResourcesClasses
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    /// <summary>
    /// CommonResources: Common resources that are used throughout all
    /// tests.
    /// </summary>
    public partial class CommonResources
    {

        /// <summary>
        /// EmailParams: Constructor for Email Constants
        /// </summary>
        public virtual EmailParams EmailParams
        {
            get
            {
                if ((this.mEmailParams == null))
                {
                    this.mEmailParams = new EmailParams();
                }
                return this.mEmailParams;
            }
        }

        private EmailParams mEmailParams;

        /// <summary>
        /// PasswordParams: Constructor for Password Constants
        /// </summary>
        public virtual PasswordParams PasswordParams
        {
            get
            {
                if ((this.mPasswordParams == null))
                {
                    this.mPasswordParams = new PasswordParams();
                }
                return this.mPasswordParams;
            }
        }

        private PasswordParams mPasswordParams;

        /// <summary>
        /// ClickElement - Simulates clicking an element
        /// </summary>
        /// <param name="element" type="HtmlControl"></param>
        public void ClickElement(HtmlControl element)
        {
            Mouse.Click(element);
        }

        /// <summary>
        /// Helper method to check if an element can be clicked
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private Boolean IsElementVisible(HtmlControl element)
        {
            try
            {
                //if(element is HtmlControl)
                //{
                this.ClickElement(element);
                return true;
                //}
                //return false;

            }
            catch (Exception exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Helper method to test if elements are visible
        /// </summary>
        /// <param name="element"></param>
        private void ElementIsVisible(HtmlControl element)
        {
            Assert.IsTrue(IsElementVisible(element), "Error: \"" + element.FriendlyName +
                "\" should be TRUE!");
        }
        /// <summary>
        /// Helper method to test if elements are not visible
        /// </summary>
        /// <param name="element"></param>
        private void ElementIsNotVisible(HtmlControl element)
        {
            Assert.IsFalse(IsElementVisible(element), "Error: \"" + element.FriendlyName +
                "\" should be FALSE!");
        }

    }

    /// <summary>
    /// EmailParams - This class contains the email constants
    /// </summary>
    public class EmailParams
    {
        /// <summary>
        /// BlankEmail - Constant: ""
        /// </summary>
        public string BlankEmail = "";
        /// <summary>
        /// ValidEmailFormat - email@email.com
        /// </summary>
        public string ValidEmailFormat = "email@email.com";
        /// <summary>
        /// InvalidEmailFormatV1 - email
        /// </summary>
        public string InvalidEmailFormatV1 = "email";
        /// <summary>
        /// InvalidEmailFormatV2 - email.com
        /// </summary>
        public string InvalidEmailFormatV2 = "email.com";
        /// <summary>
        /// InvalidEmailFormatV3 - email@
        /// </summary>
        public string InvalidEmailFormatV3 = "email@";
        /// <summary>
        /// InvalidEmailFormatV4 - email@email
        /// </summary>
        public string InvalidEmailFormatV4 = "email@email";
        /// <summary>
        /// ValidEmail - a@b.c
        /// </summary>
        public string ValidEmail = "a@b.c";
    }

    /// <summary>
    /// PasswordParams - This class contains the password constants
    /// </summary>
    public class PasswordParams
    {
        /// <summary>
        /// BlankPassword - Constant: ""
        /// </summary>
        public string BlankPassword = "";
        /// <summary>
        /// ValidPasswordFormat:
        /// * 1 Uppercase
        /// * 1 Lowercase
        /// * 1 Number
        /// * 1 Special Character
        /// * 6 or more characters
        /// </summary>
        public string ValidPasswordFormat = "Password.1";
        /// <summary>
        /// InvalidPasswordV1: All lowercase
        /// </summary>
        public string InvalidPasswordV1 = "password";
        /// <summary>
        /// InvalidPasswordV2: Uppercase and Lowercase only
        /// </summary>
        public string InvalidPasswordV2 = "Password";
        /// <summary>
        /// InvalidPasswordV3: Lowercase and Number only
        /// </summary>
        public string InvalidPasswordV3 = "password1";
        /// <summary>
        /// InvalidPasswordV4: Less than 6 characters
        /// </summary>
        public string InvalidPasswordV4 = "P@s5";
        /// <summary>
        /// Valid Password
        /// </summary>
        public string ValidPassword = "P@ssw0rd";
    }

}
