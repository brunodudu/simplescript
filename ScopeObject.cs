namespace SimpleScript
{
    class ScopeObject
    {
        public int Name { get; set; }
        public ScopeObject Next { get; set; }
        public Kind Kind { get; set; }
    }
}