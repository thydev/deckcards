using System;

namespace human
{
    public class Skeleton: Monster
    {
        //Our base monster
        public Skeleton(string name):base(name){
            this.name = name;
            this.strength = 2;
            this.intelligence = 1;
        }
    }
}