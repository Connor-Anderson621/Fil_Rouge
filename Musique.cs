using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fil_Rouge
{
    internal class Musique
    {
        public static void musique()
        {
            // Frequencies (Hz) - The Palette of Dread
            // Low Bass (The rumble)
            int C2 = 65, CS2 = 69, D2 = 73, DS2 = 78, E2 = 82, F2 = 87, FS2 = 93, G2 = 98, GS2 = 104, A2 = 110, B2 = 123;
            // Mid (The accompaniment)
            int CS3 = 139, E3 = 165, F3 = 175, FS3 = 185, G3 = 196, GS3 = 208, A3 = 220, B3 = 247;
            // High (The weeping melody)
            int C4 = 261, CS4 = 277, D4 = 294, DS4 = 311, E4 = 330, F4 = 349, FS4 = 370, GS4 = 415, A4 = 440, B4 = 494, C5 = 523, CS5 = 554;

            int tempo = 300; // Slower, heavier

            // MEASURE 1: The Pact is Sealed (C# Minor)
            // We play the Bass note briefly, then the triplet. The brain sustains the bass.
            PlayMeasure(CS2, GS3, CS4, E4, tempo);
            PlayMeasure(CS2, GS3, CS4, E4, tempo);

            // MEASURE 2: The Descent (Bass moves to B - creating tension)
            PlayMeasure(B2, GS3, CS4, E4, tempo);
            PlayMeasure(B2, GS3, CS4, E4, tempo);

            // MEASURE 3: The Realization (Bass moves to A - A Majorish, but hollow)
            PlayMeasure(A2, A3, CS4, E4, tempo);
            PlayMeasure(A2, A3, CS4, E4, tempo);

            // MEASURE 4: The Trap (Bass F# - F# Minor)
            PlayMeasure(FS2, A3, D4, FS4, tempo);
            PlayMeasure(FS2, A3, D4, FS4, tempo);

            // MEASURE 5: The Struggle (G# Major - The Dominant buildup)
            PlayMeasure(GS2, GS3, C4, FS4, tempo); // Dissonant Diminished interval here
            PlayMeasure(GS2, GS3, CS4, E4, tempo);

            // THE CLIMAX: The "Devil's Interval" (Tritone) Sequence
            // Simulates the code breaking down.
            int[] corruption = { CS4, G3, CS3, G2 }; // Tritone descent
            foreach (int note in corruption)
            {
                Console.Beep(note, 400);
                Thread.Sleep(50);
            }

            // THE FLATLINE
            // A low, long, uncomfortable rumble
            Console.WriteLine("\n[ PROCESS TERMINATED ]");
            Console.Beep(CS2, 2000);
        }

        // Helper to weave the bass and the triplet together
        static void PlayMeasure(int bass, int low, int mid, int high, int duration)
        {
            // Play Bass note (Heavy, grounding)
            Console.Beep(bass, duration + 50);

            // The Triplet Arpeggio (The anxiety)
            Console.Beep(low, duration);
            Console.Beep(mid, duration);
            Console.Beep(high, duration);
        }
    }
}

