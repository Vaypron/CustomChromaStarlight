using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomChromaStarlight
{
    class Program
    {
        static void Main(string[] args)
        {

            Key[] master = new Key[121];
            master[0] = Key.A;
            master[1] = Key.B;
            master[2] = Key.Backspace;
            master[3] = Key.C;
            master[4] = Key.CapsLock;
            master[5] = Key.D;
            master[6] = Key.D0;
            master[7] = Key.D1;
            master[8] = Key.D2;
            master[9] = Key.D3;
            master[10] = Key.D4;
            master[11] = Key.D5;
            master[12] = Key.D6;
            master[13] = Key.D7;
            master[14] = Key.D8;
            master[15] = Key.D9;
            master[16] = Key.Delete;
            master[17] = Key.Down;
            master[18] = Key.E;
            master[19] = Key.End;
            master[20] = Key.Enter;
            master[21] = Key.Escape;
            master[22] = Key.EurBackslash;
            master[23] = Key.EurPound;
            master[24] = Key.F;
            master[25] = Key.F1;
            master[26] = Key.F10;
            master[27] = Key.F11;
            master[28] = Key.F12;
            master[29] = Key.F2;
            master[30] = Key.F3;
            master[31] = Key.F4;
            master[32] = Key.F5;
            master[33] = Key.F6;
            master[34] = Key.F7;
            master[35] = Key.F8;
            master[36] = Key.F9;
            master[37] = Key.Function;
            master[38] = Key.G;
            master[39] = Key.H;
            master[40] = Key.Home;
            master[41] = Key.I;
            master[42] = Key.Insert;
            master[43] = Key.Invalid;
            master[44] = Key.J;
            master[45] = Key.Jpn3;
            master[46] = Key.Jpn4;
            master[47] = Key.Jpn5;
            master[48] = Key.JpnSlash;
            master[49] = Key.JpnYen;
            master[50] = Key.K;
            master[51] = Key.Kor2;
            master[52] = Key.Kor3;
            master[53] = Key.Kor4;
            master[54] = Key.Kor5;
            master[55] = Key.Kor6;
            master[56] = Key.Kor7;
            master[57] = Key.KorPipe;
            master[58] = Key.L;
            master[59] = Key.LeftAlt;
            master[60] = Key.LeftControl;
            master[61] = Key.LeftShift;
            master[62] = Key.LeftWindows;
            master[63] = Key.M;
            master[64] = Key.Macro1;
            master[65] = Key.Macro2;
            master[66] = Key.Macro3;
            master[67] = Key.Macro4;
            master[68] = Key.Macro5;
            master[69] = Key.N;
            master[70] = Key.Num0;
            master[71] = Key.Num1;
            master[72] = Key.Num2;
            master[73] = Key.Num3;
            master[74] = Key.Num4;
            master[75] = Key.Num5;
            master[76] = Key.Num6;
            master[77] = Key.Num7;
            master[78] = Key.Num8;
            master[79] = Key.Num9;
            master[80] = Key.NumAdd;
            master[81] = Key.NumDecimal;
            master[82] = Key.NumDivide;
            master[83] = Key.NumEnter;
            master[84] = Key.NumLock;
            master[85] = Key.NumMultiply;
            master[86] = Key.NumSubtract;
            master[87] = Key.O;
            master[88] = Key.OemApostrophe;
            master[89] = Key.OemBackslash;
            master[90] = Key.OemComma;
            master[91] = Key.OemEquals;
            master[92] = Key.OemLeftBracket;
            master[93] = Key.OemMinus;
            master[94] = Key.OemPeriod;
            master[95] = Key.OemRightBracket;
            master[96] = Key.OemSemicolon;
            master[97] = Key.OemSlash;
            master[98] = Key.OemTilde;
            master[99] = Key.P;
            master[100] = Key.PageDown;
            master[101] = Key.PageUp;
            master[102] = Key.Pause;
            master[103] = Key.PrintScreen;
            master[104] = Key.Q;
            master[105] = Key.R;
            master[106] = Key.Right;
            master[107] = Key.RightAlt;
            master[108] = Key.RightControl;
            master[109] = Key.RightMenu;
            master[110] = Key.RightShift;
            master[111] = Key.S;
            master[112] = Key.Scroll;
            master[113] = Key.Space;
            master[114] = Key.T;
            master[115] = Key.Tab;
            master[116] = Key.U;
            master[117] = Key.Up;
            master[118] = Key.V;
            master[119] = Key.W;
            master[120] = Key.X;
            master[120] = Key.Y;
            master[120] = Key.Z;

            
            //Keyboard.Instance.SetAll(new Color(0, 255, 0));
            Random rand = new Random();
            for (;;)
            {
                // Select random key, set it to random color etc.
                for (int i = 0; i < rand.Next(1, 5); i++)
                {
                    int ind = rand.Next(0, master.Length - 1);
                    try
                    {
                        Keyboard.Instance.SetKey(master[ind], new Color(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                    }
                    catch (Exception e)
                    {

                    }

                }
                Thread.Sleep(500);

                //Keyboard.Instance.SetAll(new Color(0, 255, 0));
                Keyboard.Instance.SetAll(new Color(0, 0, 0));

            }
        }
    }
}
