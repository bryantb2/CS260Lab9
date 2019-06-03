namespace NodeGraphLibrary
{
    public class Edge
    {
        //class fields
        private int endIndex;
        private int startIndex;
        private Edge next;
        int weight;
        
        //constructor
        public Edge(int startIndex,int endIndex, int weight = 0)
        {
            this.startIndex = startIndex;
            this.endIndex = endIndex;
            this.weight = weight;
        }

        //properties
        public int EndPoint
        {
            get
            {
                return this.endIndex;
            }
            set
            {
                this.endIndex = value;
            }
        }

        public int StartIndex
        {
            get
            {
                return this.startIndex;
            }
            set
            {
                this.startIndex = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public Edge Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
    }
}
