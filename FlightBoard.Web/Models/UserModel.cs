// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.UserModel
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using FlightBoard.Data;
using FlightBoard.Service.Business;
using FlightBoard.Web.Helpers;
using Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;

namespace FlightBoard.Web.Models
{
    public class UserModel
    {
        [ScaffoldColumn(false)]
        public IEnumerable<RoleModel> Roles;
        [ScaffoldColumn(false)]
        public IEnumerable<UserModel> Users;

        [HiddenInput]
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "First name is mandatory.")]
        public string FirstName { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "Last name is mandatory.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Last 4 digits of SSN")]
        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "Last 4 digits of SSN is mandatory.")]
        public string SSN { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Role")]
        [Required(ErrorMessage = "Role is mandatory.")]
        public int RoleId { get; set; }

        [ScaffoldColumn(false)]
        public string Password { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? UpdatedDate { get; set; }

        [ScaffoldColumn(false)]
        public bool? IsActive { get; set; }

        [ScaffoldColumn(false)]
        public IEnumerable<SelectListItem> RolesList
        {
            get
            {
                return (IEnumerable<SelectListItem>)new SelectList((IEnumerable)this.Roles, "RoleId", "RoleName", (object)this.RoleId);
            }
        }

        [ScaffoldColumn(false)]
        public IEnumerable<SelectListItem> UsersList
        {
            get
            {
                return (IEnumerable<SelectListItem>)new SelectList((IEnumerable)this.Users, "UserId", "UserName", (object)this.UserId);
            }
        }

        [Display(Name = "Name")]
        [JqGridColumnLayout]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true)]
        public string Name
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        [Display(Name = "Role")]
        [JqGridColumnLayout]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true)]
        //public string RoleName
        //{
           
        //    //commented
        //  //  get
        //  //  {
        //  //      using (RoleService roleService = new RoleService())
        //  //      {
        //  //          ParameterExpression parameterExpression;
        //  //          return Queryable.FirstOrDefault<fb_Roles>(Queryable.Where<fb_Roles>(((BusinessServiceBase<fb_Roles>)roleService).FindAll(), Expression.Lambda<Func<fb_Roles, bool>>((Expression)Expression.Call((Expression)Expression.Property((Expression)parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleId))), (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(int.Equals)), new Expression[1]
        //  //{
        //  //  (Expression) Expression.Property((Expression) Expression.Constant((object) this, typeof (UserModel)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (UserModel.get_RoleId)))
        //  //}), new ParameterExpression[1]
        //  //{
        //  //  parameterExpression
        //  //}))).get_RoleName();
        //  //      }
        //  //  }
        //}

        //[JqGridColumnSearchable(false)]
        //[JqGridColumnSortable(true)]
        //[EmailAddress(ErrorMessage = "Invalid email format")]
        //[JqGridColumnLayout]
        //[Display(Name = "User Name")]
        [Required(ErrorMessage = "Email is mandatory.")]
        public string UserName { get; set; }

        [JqGridColumnSortable(true)]
        [Display(Name = "SSN.No")]
        [JqGridColumnLayout]
        [JqGridColumnSearchable(false)]
        public string SSNNo
        {
            get
            {
                return this.SSN;
            }
        }

        [JqGridColumnLayout]
        [JqGridColumnSortable(false)]
        [JqGridColumnSearchable(false)]
        public string Actions
        {
            get
            {
                bool? isActive1 = this.IsActive;
                if (isActive1.GetValueOrDefault())
                {
                    int num1 = isActive1.HasValue ? 1 : 0;
                }
                bool? isActive2 = this.IsActive;
                if (isActive2.GetValueOrDefault())
                {
                    int num2 = isActive2.HasValue ? 1 : 0;
                }
                return string.Concat(new object[4]
        {
          (object) HtmlHelpers.GetEditLink(this.RoleId, this.UserId, "Edit User", "../User/Edit"),
          (object) " <a title='Delete User' class='edit-user' href='#' onclick='deleteUser(",
          (object) this.UserId,
          (object) ")'><span class='icon-delete'></span></a>"
        });
            }
        }
    }
}
