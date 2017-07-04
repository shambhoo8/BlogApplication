using InHealth_Assignment.Business;
using InHealth_Assignment.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace InHealth_Assignment.Web.Helpers
{
    public class LoginHelper
    {
        #region "Member Declaration"
        public readonly GenericService _genericService = null;
        #endregion

        #region "Constructor"
        public LoginHelper()
        {
            _genericService = new GenericService();
        }
        #endregion

        #region "Public Method"
        public LoginVM ValidateUserCredentials(LoginVM _loginVM)
        {
            var loginData = _genericService.UserRegistration.GetAll().Where(x => (x.IsActive == true && x.emailId == _loginVM.UserName));
            if(loginData.Any())
            {
                var hasPwd = loginData.FirstOrDefault().password;

                if(Utilities.utility.ValidatePassword(_loginVM.Password, hasPwd))
                {
                    if (loginData.FirstOrDefault().UserRole.RoleName.ToLower() == "admin")
                    {
                        _loginVM.RedirectURL = "/BlogPostList";
                    }
                    else
                    {
                        _loginVM.RedirectURL = "/BlogPostUser";
                    }

                    FormsAuthentication.SetAuthCookie(_loginVM.UserName, true);
                    _loginVM.Success = true;
                    _loginVM.Message = "Login successful!!!";
                    _loginVM.UserId = loginData.FirstOrDefault().Id;
                }
                else
                {
                    _loginVM = new LoginVM();
                    _loginVM.Success = false;
                    _loginVM.Message = "You have entered worng userid and password!!!";
                }
            }
            else
            {
                _loginVM = new LoginVM();
                _loginVM.Success = false;
                _loginVM.Message = "You have entered worng userid and password!!!";
            }

            return _loginVM;
        }
        #endregion

    }
}