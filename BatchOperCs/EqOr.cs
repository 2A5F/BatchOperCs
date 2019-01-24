namespace BatchOperator
{
    public static partial class BatchOperator
    {
        public static bool EqOr<T>(this T self, T a)
        {
            return self.Equals(a);
        }
        public static bool EqOr<T>(this T self, T a, T b)
        {
            return self.Equals(a) || self.Equals(b);
        }
        public static bool EqOr<T>(this T self, T a, T b, T c)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c);
        }
        public static bool EqOr<T>(this T self, T a, T b, T c, T d)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d);
        }
        public static bool EqOr<T>(this T self, T a, T b, T c, T d, T e)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e);
        }
        public static bool EqOr<T>(this T self, T a, T b, T c, T d, T e, T f)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e) || self.Equals(f);
        }
        public static bool EqOr<T>(this T self, T a, T b, T c, T d, T e, T f, T g)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e) || self.Equals(f) || self.Equals(g);
        }
        public static bool EqOr<T>(this T self, T a, T b, T c, T d, T e, T f, T g, T h)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e) || self.Equals(f) || self.Equals(g) || self.Equals(h);
        }
        public static bool EqOr<T>(this T self, object a)
        {
            return self.Equals(a);
        }
        public static bool EqOr<T>(this T self, object a, object b)
        {
            return self.Equals(a) || self.Equals(b);
        }
        public static bool EqOr<T>(this T self, object a, object b, object c)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c);
        }
        public static bool EqOr<T>(this T self, object a, object b, object c, object d)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d);
        }
        public static bool EqOr<T>(this T self, object a, object b, object c, object d, object e)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e);
        }
        public static bool EqOr<T>(this T self, object a, object b, object c, object d, object e, object f)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e) || self.Equals(f);
        }
        public static bool EqOr<T>(this T self, object a, object b, object c, object d, object e, object f, object g)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e) || self.Equals(f) || self.Equals(g);
        }
        public static bool EqOr<T>(this T self, object a, object b, object c, object d, object e, object f, object g, object h)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e) || self.Equals(f) || self.Equals(g) || self.Equals(h);
        }
        public static bool EqOr<T, A>(this T self, A a)
        {
            return self.Equals(a);
        }
        public static bool EqOr<T, A, B>(this T self, A a, B b)
        {
            return self.Equals(a) || self.Equals(b);
        }
        public static bool EqOr<T, A, B, C>(this T self, A a, B b, C c)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c);
        }
        public static bool EqOr<T, A, B, C, D>(this T self, A a, B b, C c, D d)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d);
        }
        public static bool EqOr<T, A, B, C, D, E>(this T self, A a, B b, C c, D d, E e)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e);
        }
        public static bool EqOr<T, A, B, C, D, E, F>(this T self, A a, B b, C c, D d, E e, F f)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e) || self.Equals(f);
        }
        public static bool EqOr<T, A, B, C, D, E, F, G>(this T self, A a, B b, C c, D d, E e, F f, G g)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e) || self.Equals(f) || self.Equals(g);
        }
        public static bool EqOr<T, A, B, C, D, E, F, G, H>(this T self, A a, B b, C c, D d, E e, F f, G g, H h)
        {
            return self.Equals(a) || self.Equals(b) || self.Equals(c) || self.Equals(d) || self.Equals(e) || self.Equals(f) || self.Equals(g) || self.Equals(h);
        }
        public static bool EqOr<T>(this T self, params T[] others)
        {
            if (others.Length == 0) return false;
            foreach (var other in others)
            {
                if (self.Equals(others))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool EqOr<T>(this T self, params object[] others)
        {
            if (others.Length == 0) return false;
            foreach (var other in others)
            {
                if (self.Equals(others))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
