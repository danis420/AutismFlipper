using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AutismFlipper.Currency;

namespace AutismFlipper
{
    class Stash
    {
        private String currencyToLoot;
        private int amount;
        private int x;
        private int y;
        private int stack;
        private Chaos chaos;
        private Alchemy alchemy;
        private Alteration alteration;
        private Cartographer_chisel chisel;
        private Fusing fusing;
        private Jeweller jeweller;
        private Scouring scouring;
        private Chromatic chrome;
        private Regret regret;
        private Vaal vaal;
        private Silver_coin silver;
        private Perandus_coin perandus;
        private Apprentice_sextant apprentice;
        private Journeyman_sextant journeyman;
        private Master_sextant master;
        private Divine divine;
        private Blessed blessed;
        private Regal regal;
        private Exalted exalted;
        private Mirror mirror;
        private Chance chance;
        private Annulment annulment;
        private Gemcutter_prism gcp;
        private Glassblower_bauble bauble;
        private Blacksmith_whetstone whetstone;
        private Armourer_scrap armourer;
        private Transmutation transmutation;
        private Augment augment;

        public Stash(string currencyToLoot, int amount)
        {
            this.currencyToLoot = currencyToLoot;
            this.amount = amount;
            lootFromStash();

        }

        public void lootFromStash()
        {
            switch (currencyToLoot)
            {
                case "chaos":
                    chaos = new Chaos();
                    openStash();
                    lootChaos(chaos.getChaosX(), chaos.getChaosY(), amount, chaos.getChaosStack());
                    break;
                case "alchemy":
                    alchemy = new Alchemy();
                    x = alchemy.getAlchemyX();
                    y = alchemy.getAlchemyY();
                    stack = alchemy.getAlchemyStack();
                    Console.WriteLine(x + " " + y + " " + stack);
                    break;
                case "alteration":
                    break;
                case "chisel":
                    break;
                case "fusing":
                    break;
                case "chrome":
                    break;
                case "jeweller's":
                    break;
                case "scouring":
                    break;
                case "regret":
                    break;
                case "vaal":
                    break;
                case "silver":
                    break;
                case "coin":
                    break;
                case "apprentice sextant":
                    break;
                case "journeyman sextant":
                    break;
                case "master sextant":
                    break;
                case "divine":
                    break;
                case "blessed":
                    break;
                case "regal":
                    break;
                case "exalted":
                    break;
                case "chance":
                    break;
                case "Annulment":
                    break;
                case "armourer's":
                    break;
                case "whetstone":
                    break;
                case "bauble":
                    break;
                case "gcp":
                    break;
                case "augmentation":
                    break;
                case "mirror":
                    break;
                case "transmutation":
                    break;
                default:
                    break;
            }
        }

        // mouse

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        internal static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

#pragma warning disable 649
        internal struct INPUT
        {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        internal struct MOUSEINPUT
        {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }


        // mouse


        public void openStash()
        {
            //stash 993 473
        }
        public void lootChaos(int x, int y, int amount, int stacksize)
        {
            //move cursor to x y
            if(amount%stacksize == 0)
            {
                //click amount/stacksize
            }
        }
    }
}
