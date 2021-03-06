﻿using System;

namespace GameOfLife.Seeders
{
    public class SeederFactory
    {
        public IDefineASeeder Create(SeederEnum seederType)
        {
            switch (seederType)
            {
                case SeederEnum.Blinker:
                    return new BlinkerSeeder();
                case SeederEnum.Beacon:
                    return new BeaconSeeder();
                case SeederEnum.Random:
                    return new RandomSeeder();
                default:
                    throw new ApplicationException("Seeder Type not handled").AddData("seederType", seederType);
            }
        }
    }
}
