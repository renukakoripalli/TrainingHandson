using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnLSP
{
    public abstract class Animals
    {
        public abstract string GetSound();
    }
    public class Dog : Animals
    {
        public override string GetSound()
        {
            return "Bow Bow";
        }
    }
    public class Cat : Animals
    {
        public override string GetSound()
        {
            return "Meow Meow";
        }
    }
    public class Snake:Animals
    {
        public override string GetSound()
        {
            return "Bush Bush";
        }
    }
}
