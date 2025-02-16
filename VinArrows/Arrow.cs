﻿// Written by Grace Ofure Agbenin
// Feb 13, 2025

using System;

namespace VinArrows
{
    // Define enumerations for arrowhead and fletching types
    public enum ArrowheadType
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum FletchingType
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }

    public class Arrow
    {
        public ArrowheadType arrowhead;
        public float shaftLength;
        public FletchingType fletching;

        public Arrow(ArrowheadType arrowhead, FletchingType fletching, float length)
        {
            this.arrowhead = arrowhead;
            this.fletching = fletching;
            this.shaftLength = length;
        }

        public float GetCost()
        {
            float arrowheadCost = arrowhead switch
            {
                ArrowheadType.Steel => 10,
                ArrowheadType.Wood => 3,
                ArrowheadType.Obsidian => 5,
                _ => 0 // Default case (not strictly necessary here)
            };

            float fletchingCost = fletching switch
            {
                FletchingType.Plastic => 10,
                FletchingType.TurkeyFeathers => 5,
                FletchingType.GooseFeathers => 3,
                _ => 0 // Default case (not strictly necessary here)
            };

            float shaftCost = 0.05f * shaftLength;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }

}