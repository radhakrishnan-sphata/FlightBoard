

using Lib.Web.Mvc.JQuery.JqGrid;
using System.Collections.Generic;
using System.Text;

namespace FlightBoard.Core.Utilities
{
    public static class JQGridFilterHelper
    {
        //public static string SearchFilterExpression(JqGridRequest request)
        //{
        //    string str1 = string.Empty;
        //    if (request.get_Searching())
        //    {
        //        if (request.get_SearchingFilter() != null)
        //            str1 = JQGridFilterHelper.GetFilter(request.get_SearchingFilter().get_SearchingName(), request.get_SearchingFilter().get_SearchingOperator(), request.get_SearchingFilter().get_SearchingValue());
        //        else if (request.get_SearchingFilters() != null)
        //        {
        //            StringBuilder stringBuilder = new StringBuilder();
        //            string str2 = ((object)request.get_SearchingFilters().get_GroupingOperator()).ToString();
        //            using (List<JqGridRequestSearchingFilter>.Enumerator enumerator = request.get_SearchingFilters().get_Filters().GetEnumerator())
        //            {
        //                while (enumerator.MoveNext())
        //                {
        //                    JqGridRequestSearchingFilter current = enumerator.Current;
        //                    stringBuilder.Append(JQGridFilterHelper.GetFilter(current.get_SearchingName(), current.get_SearchingOperator(), current.get_SearchingValue()));
        //                    stringBuilder.Append(string.Format(" {0} ", (object)str2));
        //                }
        //            }
        //            if (stringBuilder.Length > 0)
        //                stringBuilder.Remove(stringBuilder.Length - str2.Length - 2, str2.Length + 2);
        //            str1 = stringBuilder.ToString();
        //        }
        //    }
        //    return str1;
        //}

        //public static string SearchFilterExpression(JqGridRequest request, string whereCondition)
        //{
        //    string str1 = string.Empty;
        //    string str2 = JQGridFilterHelper.SearchFilterExpression(request);
        //    return !string.IsNullOrEmpty(str2) ? str2 + " && " + whereCondition : whereCondition;
        //}

        //private static string GetFilter(string searchingName, JqGridSearchOperators searchingOperator, string searchingValue)
        //{
        //    string str1 = string.Empty;
        //    JqGridSearchOperators gridSearchOperators1 = searchingOperator;
        //    if (gridSearchOperators1 <= 8)
        //    {
        //        switch (gridSearchOperators1 - 1)
        //        {
        //            case 0:
        //                str1 = "=";
        //                break;
        //            case 1:
        //                str1 = "!=";
        //                break;
        //            case 2:
        //                break;
        //            case 3:
        //                str1 = "<";
        //                break;
        //            default:
        //                if (gridSearchOperators1 == 8)
        //                {
        //                    str1 = "<=";
        //                    break;
        //                }
        //                break;
        //        }
        //    }
        //    else if (gridSearchOperators1 != 16)
        //    {
        //        if (gridSearchOperators1 == 32)
        //            str1 = ">=";
        //    }
        //    else
        //        str1 = ">";
        //    string str2 = "\"";
        //    if (searchingName.Trim().ToUpper().Equals("ISACTIVE"))
        //        str2 = "";
        //    JqGridSearchOperators gridSearchOperators2 = searchingOperator;
        //    if (gridSearchOperators2 <= 1024)
        //    {
        //        if (gridSearchOperators2 == 64)
        //            return string.Format("{0}.StartsWith({1}{2}{1})", (object)searchingName, (object)str2, (object)searchingValue);
        //        if (gridSearchOperators2 == 128)
        //            return string.Format("!{0}.StartsWith({1}{2}{1})", (object)searchingName, (object)str2, (object)searchingValue);
        //        if (gridSearchOperators2 == 1024)
        //            return string.Format("{0}.EndsWith({1}{2}{1})", (object)searchingName, (object)str2, (object)searchingValue);
        //    }
        //    else
        //    {
        //        if (gridSearchOperators2 == 2048)
        //            return string.Format("!{0}.EndsWith({1}{2}{1})", (object)searchingName, (object)str2, (object)searchingValue);
        //        if (gridSearchOperators2 == 4096)
        //            return string.Format("{0}.Contains({1}{2}{1})", (object)searchingName, (object)str2, (object)searchingValue);
        //        if (gridSearchOperators2 == 8192)
        //            return string.Format("!{0}.Contains({1}{2}{1})", (object)searchingName, (object)str2, (object)searchingValue);
        //    }
        //    return string.Format("{0} {1} {2}{3}{2}", (object)searchingName, (object)str1, (object)str2, (object)searchingValue);
        //}
    }
}
