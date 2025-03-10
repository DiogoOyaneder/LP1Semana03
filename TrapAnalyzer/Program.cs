﻿using System;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {

            {
                PlayerGear gear = PlayerGear.None;
                foreach (string arg in args)
                {
                    if (arg.Equals("Helmet", StringComparison.OrdinalIgnoreCase))
                        gear|= PlayerGear.Helmet;
                    else if (arg.Equals("Shield", StringComparison.OrdinalIgnoreCase))
                        gear|= PlayerGear.Shield;
                    else if (arg.Equals("Boots", StringComparison.OrdinalIgnoreCase))
                        gear|= PlayerGear.Boots;
                }

                return gear;
            }

        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {

            {
                switch (trap)
                {
                    case TrapType.FallingRocks:
                        return (gear &(PlayerGear.Helmet|PlayerGear.Boots)) == (PlayerGear.Helmet|PlayerGear.Boots);

                    case TrapType.SpinningBlades:
                        return (gear &(PlayerGear.Shield|PlayerGear.Boots)) == (PlayerGear.Shield|PlayerGear.Boots);

                    case TrapType.PoisonGas:
                        return (gear &(PlayerGear.Helmet|PlayerGear.Shield)) == (PlayerGear.Helmet|PlayerGear.Shield);

                    case TrapType.LavaPit:
                        return (gear &(PlayerGear.Helmet|PlayerGear.Shield|PlayerGear.Boots)) == (PlayerGear.Helmet|PlayerGear.Shield|PlayerGear.Boots);

                    default:
                        return false;
                }
            }


        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {

            string result = survives?"survives" : "dies due to";
            Console.WriteLine($"Player {result} {trap}");
        }

    }
}

