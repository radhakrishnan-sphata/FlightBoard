// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.UserService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FlightBoard.Service.Business
{
  public class UserService : BusinessServiceBase<fb_Users>
  {
    //private static UserService defaultInstance = new UserService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static UserService Default
    //{
    //  get
    //  {
    //    return UserService.defaultInstance;
    //  }
    //}

      public UserService()
      {
      }

      public UserService(Repository<fb_Users> repository)
          : base(repository)
      {
      }

    public UserService(DbContext dbContext)
      : base(dbContext)
    {
    }

    public fb_Users IsValidUser(string email, string password)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      //UserService.\u003C\u003Ec__DisplayClass0 cDisplayClass0 = new UserService.\u003C\u003Ec__DisplayClass0();
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass0.email = email;
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass0.encryptedString = password;
      //ParameterExpression parameterExpression;
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: field reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: field reference
      //return Queryable.FirstOrDefault<fb_Users>(Queryable.Where<fb_Users>(this.FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Equals)), new Expression[1]
      //{
      //  (Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClass0.email))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), new Expression[0])
      //}), (Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_Password))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Equals)), new Expression[1]
      //{
      //  (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClass0.encryptedString)))
      //})), new ParameterExpression[1]
      //{
      //  parameterExpression
      //})));

        return null;
    }

    //public fb_Users checkUserByPassword(string password, int user_id)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  UserService.\u003C\u003Ec__DisplayClass2 cDisplayClass2 = new UserService.\u003C\u003Ec__DisplayClass2();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass2.user_id = user_id;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass2.encryptedString = password;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Queryable.FirstOrDefault<fb_Users>(Queryable.Where<fb_Users>(this.FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_Password))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass2), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClass2.encryptedString)))
    //  }), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass2), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClass2.user_id))))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //}

    //public bool ChangeUserPassword(string password, string currentPassword, int user_id)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  UserService.\u003C\u003Ec__DisplayClass4 cDisplayClass4 = new UserService.\u003C\u003Ec__DisplayClass4();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass4.user_id = user_id;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass4.encryptedString = currentPassword;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  fb_Users entity = Queryable.FirstOrDefault<fb_Users>(Queryable.Where<fb_Users>(this.FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass4), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClass4.user_id)))
    //  }), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_Password))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass4), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClass4.encryptedString))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.op_Equality)))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //  if (entity == null)
    //    return false;
    //  entity.set_Password(password);
    //  this.Update(entity, true);
    //  return true;
    //}

    //public fb_Users CheckUserDetails(string username, string ssn)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  UserService.\u003C\u003Ec__DisplayClass6 cDisplayClass6 = new UserService.\u003C\u003Ec__DisplayClass6();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass6.username = username;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass6.ssn = ssn;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Queryable.FirstOrDefault<fb_Users>(Queryable.Where<fb_Users>(this.FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass6), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClass6.username))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), new Expression[0])
    //  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_SSN))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass6), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClass6.ssn)))
    //  })), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //}

    //public fb_Users FindByID(int id)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  UserService.\u003C\u003Ec__DisplayClass8 cDisplayClass8 = new UserService.\u003C\u003Ec__DisplayClass8();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass8.id = id;
    //  try
    //  {
    //    ParameterExpression parameterExpression;
    //    // ISSUE: method reference
    //    // ISSUE: field reference
    //    return Queryable.FirstOrDefault<fb_Users>(Queryable.Where<fb_Users>(this.FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass8), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClass8.id)))), new ParameterExpression[1]
    //    {
    //      parameterExpression
    //    })));
    //  }
    //  catch (Exception ex)
    //  {
    //  }
    //  return (fb_Users) null;
    //}

    //public bool IsUserNameExist(string username)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  UserService.\u003C\u003Ec__DisplayClassa cDisplayClassa = new UserService.\u003C\u003Ec__DisplayClassa();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassa.username = username;
    //  // ISSUE: reference to a compiler-generated field
    //  if (cDisplayClassa.username == null)
    //    return false;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  return Queryable.FirstOrDefault<fb_Users>(Queryable.Where<fb_Users>(this.FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassa), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClassa.username))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), new Expression[0])
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  }))) != null;
    //}

    //public bool IsUserNameExist(string username, int userId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  UserService.\u003C\u003Ec__DisplayClassc cDisplayClassc = new UserService.\u003C\u003Ec__DisplayClassc();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassc.username = username;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassc.userId = userId;
    //  // ISSUE: reference to a compiler-generated field
    //  if (cDisplayClassc.username == null)
    //    return false;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Queryable.FirstOrDefault<fb_Users>(Queryable.Where<fb_Users>(this.FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassc), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClassc.username))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), new Expression[0])
    //  }), (Expression) Expression.NotEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassc), FieldInfo.GetFieldFromHandle(__fieldref (UserService.\u003C\u003Ec__DisplayClassc.userId))))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  }))) != null;
    //}
  }
}
