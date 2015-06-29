using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Course
    {

        private String name = "";
        private String date = "";
        private String cost = "";
        private String spaces = "";
        private int i = 0;
        private int j = 0;
        private int count = 0;


        public Course(String name, String date, String cost, String spaces, int i, int j)
        {
            this.name = name;
            this.date = date;
            this.cost = cost;
            this.spaces = spaces;
            this.i = i;
            this.j = j;


        }
       
        public void setName(String name)
        {
            this.name = name;
        }

        public String getName() 
        {
            return name;
        }

        public void setDate(String date) 
        {
            this.date = date;
        }

        public String getDate()
        {
            return date;
        }

        public void setCost(String cost)
        {
            this.cost = cost;
        }

        public String getCost()
        {
            return cost;
        }

        public void setSpaces(String spaces) 
        {
            this.spaces = spaces;
        }

        public String getSpaces()
        {
            return spaces;
        }

        public void setCount(int count)
        {
            this.count = count;
        }

        public int getCount()
        {
            return count;
        }

        public String toString()
        {
            return name + "/r/n" + date + "/r/n" + cost + "/r/n" + spaces;
        }

        

    }
}
