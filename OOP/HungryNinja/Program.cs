﻿using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            Ninja ninja = new Ninja();
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
            ninja.Eat(buffet.Serve());
        }
    }
}
