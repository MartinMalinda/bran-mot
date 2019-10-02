using System;
namespace AbstractsAndInterfaces
{
    public class Thing : IComparable
    {
        private string name;
        private bool completed;

        //Kerrial's code
        //public string Name
        //{
        //    get { return __name; }
        //    set {

        //        if(value == "bob")
        //        {
        //            Name = value; 
        //        }
        //    }
        //}


        public Thing(string name)
        {
            this.name = name;
        }

        public void Complete()
        {
            completed = true;
        }
        public string GetName()
        {
            return this.name;
        }
        public bool GetComplete()
        {
            return this.completed;
        }

        public int CompareTo(object obj)
        {
            if (completed.CompareTo(obj) > 1)
            {
                return name.CompareTo(obj);
            }
            else return completed.CompareTo(obj);
        }
    }
}
