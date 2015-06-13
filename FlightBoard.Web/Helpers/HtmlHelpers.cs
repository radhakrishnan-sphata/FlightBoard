namespace FlightBoard.Web.Helpers
{
    public class HtmlHelpers
    {
        public static string GetEditLink(int roleId, int userId, string title, string url)
        {
            if (roleId <= 0)
                return "<a title='" + title + "' class='edit-user' href='javascript:void(0)'><span class='icon-editdisable'></span></a>";
            return "<a title='" + title + "' class='edit-user' href='" + string.Format(url + "/{0}", (object)userId) + "'><span class='icon-edit'></span></a>";
        }
    }
}
