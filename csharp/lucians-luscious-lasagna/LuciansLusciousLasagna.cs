using Microsoft.VisualBasic;
using System;

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMins) => ExpectedMinutesInOven() - actualMins;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numOfLayers) => numOfLayers * 2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numOfLayers, int numOfMins) => PreparationTimeInMinutes(numOfLayers) + ExpectedMinutesInOven() - RemainingMinutesInOven(numOfMins);
}
