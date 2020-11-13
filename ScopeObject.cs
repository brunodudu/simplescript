namespace SimpleScript
{
    class ScopeObject
    {
        public int Name { get; set; }
        public ScopeObject Next { get; set; }
        public Kind Kind { get; set; }

        public bool Equals(ScopeObject other)
        {
            if (this.Name == other.Name && this.Kind == other.Kind)
            {
                if (this.Next == null && other.Next == null) return true;
                else if (this.Next == null && other.Next != null) return false;
                else if (this.Next != null && other.Next == null) return false;
                else return this.Next.Equals(other.Next);
            }
            else return false;
        }
    }
}