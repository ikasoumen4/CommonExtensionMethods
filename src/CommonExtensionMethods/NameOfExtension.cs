public static class NameOf{

    public static string Variable<T>(System.Linq.Expressions.Expression<Func<T>> e)
        {
            var member = (System.Linq.Expressions.MemberExpression)e.Body;
            return member.Member.Name;
        }
        public static string NameOf<T>()
        {
            return typeof(T).Name;
        }

}