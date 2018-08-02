using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutismFlipper
{
    class Currency
    {
        private Blacksmith_whetstone blacksmith_whetstone;
        private Armourer_scrap armourer_scrap;
        private Glassblower_bauble glassblower_bauble;
        private Gemcutter_prism gemcutter_prism;
        private Cartographer_chisel cartographer_chisel;
        private Transmutation transmutation;
        private Alteration alteration;
        private Annulment annulment;
        private Chance chance;
        private Augment augment;
        private Exalted exalted;
        private Mirror mirror;
        private Regal regal;
        private Alchemy alchemy;
        private Chaos chaos;
        private Blessed blessed;
        private Divine divine;
        private Jeweller jeweller;
        private Fusing fusing;
        private Chromatic chromatic;
        private Scouring scouring;
        private Regret regret;
        private Vaal vaal;
        private Silver_coin silver_coin;
        private Perandus_coin perandus_coin;
        private Apprentice_sextant apprentice_sextant;
        private Journeyman_sextant journeyman_sextant;
        private Master_sextant master_sextant;

        public Currency(Blacksmith_whetstone blacksmith_whetstone, Armourer_scrap armourer_scrap, Glassblower_bauble glassblower_bauble, Gemcutter_prism gemcutter_prism, Cartographer_chisel cartographer_chisel, Transmutation transmutation, Alteration alteration, Annulment annulment, Chance chance, Augment augment, Exalted exalted, Mirror mirror, Regal regal, Alchemy alchemy, Chaos chaos, Blessed blessed, Divine divine, Jeweller jeweller, Fusing fusing, Chromatic chromatic, Scouring scouring, Regret regret, Vaal vaal, Silver_coin silver_coin, Perandus_coin perandus_coin, Apprentice_sextant apprentice_sextant, Journeyman_sextant journeyman_sextant, Master_sextant master_sextant)
        {
            this.blacksmith_whetstone = blacksmith_whetstone;
            this.armourer_scrap = armourer_scrap;
            this.glassblower_bauble = glassblower_bauble;
            this.gemcutter_prism = gemcutter_prism;
            this.cartographer_chisel = cartographer_chisel;
            this.transmutation = transmutation;
            this.alteration = alteration;
            this.annulment = annulment;
            this.chance = chance;
            this.augment = augment;
            this.exalted = exalted;
            this.mirror = mirror;
            this.regal = regal;
            this.alchemy = alchemy;
            this.chaos = chaos;
            this.blessed = blessed;
            this.divine = divine;
            this.jeweller = jeweller;
            this.fusing = fusing;
            this.chromatic = chromatic;
            this.scouring = scouring;
            this.regret = regret;
            this.vaal = vaal;
            this.silver_coin = silver_coin;
            this.perandus_coin = perandus_coin;
            this.apprentice_sextant = apprentice_sextant;
            this.journeyman_sextant = journeyman_sextant;
            this.master_sextant = master_sextant;
        }

        internal class Blacksmith_whetstone
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Blacksmith_whetstone()
            {
                this.stacksize = 20;
                this.x = 370;
                this.y = 250;
            }

            public int getBlacksmithStack()
            {
                return stacksize;
            }

            public int getBlacksmithX()
            {
                return x;
            }

            public int getBlacksmithY()
            {
                return y;
            }

            public int getBlacksmithamount()
            {
                return amount;
            }

            public void setBlacksmith(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Armourer_scrap
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Armourer_scrap()
            {
                this.stacksize = 40;
                this.x = 430;
                this.y = 250;
            }

            public int getArmourerStack()
            {
                return stacksize;
            }

            public int getArmourerX()
            {
                return x;
            }

            public int getArmourerY()
            {
                return y;
            }

            public int getArmoureramount()
            {
                return amount;
            }

            public void setArmourer(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Glassblower_bauble
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Glassblower_bauble()
            {
                this.stacksize = 20;
                this.x = 490;
                this.y = 250;
            }

            public int getGlassblowerStack()
            {
                return stacksize;
            }

            public int getGlassblowerX()
            {
                return x;
            }

            public int getGlassblowerY()
            {
                return y;
            }

            public int getGlassbloweramount()
            {
                return amount;
            }

            public void setGlassblower(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Gemcutter_prism
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Gemcutter_prism()
            {
                this.stacksize = 20;
                this.x = 550;
                this.y = 250;
            }

            public int getGemcutterStack()
            {
                return stacksize;
            }

            public int getGemcutterX()
            {
                return x;
            }

            public int getGemcutterY()
            {
                return y;
            }

            public int getGemcutteramount()
            {
                return amount;
            }

            public void setGemcutter(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Cartographer_chisel
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Cartographer_chisel()
            {
                this.stacksize = 20;
                this.x = 610;
                this.y = 250;
            }

            public int getCartographerStack()
            {
                return stacksize;
            }

            public int getCartographerX()
            {
                return x;
            }

            public int getCartographerY()
            {
                return y;
            }

            public int getCartographeramount()
            {
                return amount;
            }

            public void setCartographer(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Master_sextant
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Master_sextant()
            {
                this.stacksize = 10;
                this.x = 550;
                this.y = 530;
            }

            public int getMasterStack()
            {
                return stacksize;
            }

            public int getMasterX()
            {
                return x;
            }

            public int getMasterY()
            {
                return y;
            }

            public int getMasteramount()
            {
                return amount;
            }

            public void setMaster(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Journeyman_sextant
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Journeyman_sextant()
            {
                this.stacksize = 10;
                this.x = 490;
                this.y = 530;
            }

            public int getJourneymanStack()
            {
                return stacksize;
            }

            public int getJourneymanX()
            {
                return x;
            }

            public int getJourneymanY()
            {
                return y;
            }

            public int getJourneymanamount()
            {
                return amount;
            }

            public void setJourneyman(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Apprentice_sextant
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Apprentice_sextant()
            {
                this.stacksize = 10;
                this.x = 430;
                this.y = 530;
            }

            public int getApprenticeStack()
            {
                return stacksize;
            }

            public int getApprenticeX()
            {
                return x;
            }

            public int getApprenticeY()
            {
                return y;
            }

            public int getApprenticeamount()
            {
                return amount;
            }

            public void setApprentice(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Perandus_coin
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Perandus_coin()
            {
                this.stacksize = 1000;
                this.x = 180;
                this.y = 530;
            }

            public int getPerandusStack()
            {
                return stacksize;
            }

            public int getPerandusX()
            {
                return x;
            }

            public int getPerandusY()
            {
                return y;
            }

            public int getPerandusamount()
            {
                return amount;
            }

            public void setPerandus(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Silver_coin
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Silver_coin()
            {
                this.stacksize = 30;
                this.x = 230;
                this.y = 530;
            }

            public int getSilverStack()
            {
                return stacksize;
            }

            public int getSilverX()
            {
                return x;
            }

            public int getSilverY()
            {
                return y;
            }

            public int getSilveramount()
            {
                return amount;
            }

            public void setSilver(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Vaal
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Vaal()
            {
                this.stacksize = 10;
                this.x = 550;
                this.y = 480;
            }

            public int getVaalStack()
            {
                return stacksize;
            }

            public int getVaalX()
            {
                return x;
            }

            public int getVaalY()
            {
                return y;
            }

            public int getVaalamount()
            {
                return amount;
            }

            public void setVaal(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Regret
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Regret()
            {
                this.stacksize = 40;
                this.x = 490;
                this.y = 480;
            }

            public int getRegretStack()
            {
                return stacksize;
            }

            public int getRegretX()
            {
                return x;
            }

            public int getRegretY()
            {
                return y;
            }

            public int getRegretamount()
            {
                return amount;
            }

            public void setRegret(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Scouring
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Scouring()
            {
                this.stacksize = 30;
                this.x = 430;
                this.y = 480;
            }

            public int getScouringStack()
            {
                return stacksize;
            }

            public int getScouringX()
            {
                return x;
            }

            public int getScouringY()
            {
                return y;
            }

            public int getScouringamount()
            {
                return amount;
            }

            public void setScouring(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Chromatic
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Chromatic()
            {
                this.stacksize = 20;
                this.x = 230;
                this.y = 480;
            }

            public int getChromaticStack()
            {
                return stacksize;
            }

            public int getChromaticX()
            {
                return x;
            }

            public int getChromaticY()
            {
                return y;
            }

            public int getChromaticamount()
            {
                return amount;
            }

            public void setChromatic(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Fusing
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Fusing()
            {
                this.stacksize = 20;
                this.x = 175;
                this.y = 480;
            }

            public int getFusingStack()
            {
                return stacksize;
            }

            public int getFusingX()
            {
                return x;
            }

            public int getFusingY()
            {
                return y;
            }

            public int getFusingamount()
            {
                return amount;
            }

            public void setFusing(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Jeweller
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Jeweller()
            {
                this.stacksize = 20;
                this.x = 110;
                this.y = 480;
            }

            public int getJewellerStack()
            {
                return stacksize;
            }

            public int getJewellerX()
            {
                return x;
            }

            public int getJewellerY()
            {
                return y;
            }

            public int getJewelleramount()
            {
                return amount;
            }

            public void setJeweller(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Divine
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Divine()
            {
                this.stacksize = 10;
                this.x = 610;
                this.y = 390;
            }

            public int getDivineStack()
            {
                return stacksize;
            }

            public int getDivineX()
            {
                return x;
            }

            public int getDivineY()
            {
                return y;
            }

            public int getDivineamount()
            {
                return amount;
            }

            public void setDivine(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Blessed
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Blessed()
            {
                this.stacksize = 20;
                this.x = 610;
                this.y = 330;
            }

            public int getBlessedStack()
            {
                return stacksize;
            }

            public int getBlessedX()
            {
                return x;
            }

            public int getBlessedY()
            {
                return y;
            }

            public int getBlessedamount()
            {
                return amount;
            }

            public void setBlessed(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Chaos
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Chaos()
            {
                this.stacksize = 10;
                this.x = 550;
                this.y = 330;
            }

            public int getChaosStack()
            {
                return stacksize;
            }

            public int getChaosX()
            {
                return x;
            }

            public int getChaosY()
            {
                return y;
            }

            public int getChaosamount()
            {
                return amount;
            }

            public void setChaos(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Alchemy
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Alchemy()
            {
                this.stacksize = 10;
                this.x = 490;
                this.y = 330;
            }

            public int getAlchemyStack()
            {
                return stacksize;
            }

            public int getAlchemyX()
            {
                return x;
            }

            public int getAlchemyY()
            {
                return y;
            }

            public int getAlchemyamount()
            {
                return amount;
            }

            public void setAlchemy(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Regal
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Regal()
            {
                this.stacksize = 10;
                this.x = 430;
                this.y = 330;
            }

            public int getRegalStack()
            {
                return stacksize;
            }

            public int getRegalX()
            {
                return x;
            }

            public int getRegalY()
            {
                return y;
            }

            public int getRegalamount()
            {
                return amount;
            }

            public void setRegal(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Mirror
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Mirror()
            {
                this.stacksize = 10;
                this.x = 360;
                this.y = 330;
            }

            public int getMirrorStack()
            {
                return stacksize;
            }

            public int getMirrorX()
            {
                return x;
            }

            public int getMirrorY()
            {
                return y;
            }

            public int getMirroramount()
            {
                return amount;
            }

            public void setMirror(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Exalted
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Exalted()
            {
                this.stacksize = 10;
                this.x = 300;
                this.y = 330;
            }

            public int getExaltedStack()
            {
                return stacksize;
            }

            public int getExaltedX()
            {
                return x;
            }

            public int getExaltedY()
            {
                return y;
            }

            public int getExaltedamount()
            {
                return amount;
            }

            public void setExalted(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Augment
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Augment()
            {
                this.stacksize = 30;
                this.x = 230;
                this.y = 390;
            }

            public int getAugmentStack()
            {
                return stacksize;
            }

            public int getAugmentX()
            {
                return x;
            }

            public int getAugmentY()
            {
                return y;
            }

            public int getAugmentamount()
            {
                return amount;
            }

            public void setAugment(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Chance
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Chance()
            {
                this.stacksize = 20;
                this.x = 230;
                this.y = 330;
            }

            public int getChanceStack()
            {
                return stacksize;
            }

            public int getChanceX()
            {
                return x;
            }

            public int getChanceY()
            {
                return y;
            }

            public int getChanceamount()
            {
                return amount;
            }

            public void setChance(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Annulment
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Annulment()
            {
                this.stacksize = 20;
                this.x = 175;
                this.y = 330;
            }

            public int getAnnulmentStack()
            {
                return stacksize;
            }

            public int getAnnulmentX()
            {
                return x;
            }

            public int getAnnulmentY()
            {
                return y;
            }

            public int getAnnulmentamount()
            {
                return amount;
            }

            public void setAnnulment(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Alteration
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Alteration()
            {
                this.stacksize = 20;
                this.x = 110;
                this.y = 330;
            }

            public int getAlterationStack()
            {
                return stacksize;
            }

            public int getAlterationX()
            {
                return x;
            }

            public int getAlterationY()
            {
                return y;
            }

            public int getAlterationamount()
            {
                return amount;
            }

            public void setAlteration(int amount)
            {
                this.amount = amount;
            }
        }

        internal class Transmutation
        {
            private int stacksize;
            private int x;
            private int y;
            private int amount;

            public Transmutation()
            {
                this.stacksize = 40;
                this.x = 60;
                this.y = 330;
            }

            public int getTransmutationStack()
            {
                return stacksize;
            }

            public int getTransmutationX()
            {
                return x;
            }

            public int getTransmutationY()
            {
                return y;
            }

            public int getTransmutationamount()
            {
                return amount;
            }

            public void setTransmutation(int amount)
            {
                this.amount = amount;
            }
        }
    }
}