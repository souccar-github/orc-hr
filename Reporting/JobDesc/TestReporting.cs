﻿//using DevExpress.XtraReports.UI;

//namespace Reporting.JobDesc
//{
//    public partial class TestReporting : XtraReport
//    {
//        public TestReporting()
//        {
//            InitializeComponent();

//            string rtf =
//                @"{\rtf1\adeflang1025\ansi\ansicpg1256\uc1\adeff31507\deff0\stshfdbch31505\stshfloch31506\stshfhich31506\stshfbi31507\deflang1033\deflangfe1033\themelang1033\themelangfe0\themelangcs1025{\fonttbl{\f34\fbidi \froman\fcharset1\fprq2{\*\panose 02040503050406030204}Cambria Math;}{\f37\fbidi \fswiss\fcharset0\fprq2{\*\panose 020f0502020204030204}Calibri;}
//{\f39\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0604030504040204}Tahoma;}{\flomajor\f31500\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
//{\fdbmajor\f31501\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhimajor\f31502\fbidi \froman\fcharset0\fprq2{\*\panose 02040503050406030204}Cambria;}
//{\fbimajor\f31503\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\flominor\f31504\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
//{\fdbminor\f31505\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhiminor\f31506\fbidi \fswiss\fcharset0\fprq2{\*\panose 020f0502020204030204}Calibri;}
//{\fbiminor\f31507\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0604020202020204}Arial;}{\f410\fbidi \fswiss\fcharset238\fprq2 Calibri CE;}{\f411\fbidi \fswiss\fcharset204\fprq2 Calibri Cyr;}{\f413\fbidi \fswiss\fcharset161\fprq2 Calibri Greek;}
//{\f414\fbidi \fswiss\fcharset162\fprq2 Calibri Tur;}{\f417\fbidi \fswiss\fcharset186\fprq2 Calibri Baltic;}{\f418\fbidi \fswiss\fcharset163\fprq2 Calibri (Vietnamese);}{\flomajor\f31508\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
//{\flomajor\f31509\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\flomajor\f31511\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\flomajor\f31512\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
//{\flomajor\f31513\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\flomajor\f31514\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\flomajor\f31515\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
//{\flomajor\f31516\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fdbmajor\f31518\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fdbmajor\f31519\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
//{\fdbmajor\f31521\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fdbmajor\f31522\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fdbmajor\f31523\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
//{\fdbmajor\f31524\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fdbmajor\f31525\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fdbmajor\f31526\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
//{\fhimajor\f31528\fbidi \froman\fcharset238\fprq2 Cambria CE;}{\fhimajor\f31529\fbidi \froman\fcharset204\fprq2 Cambria Cyr;}{\fhimajor\f31531\fbidi \froman\fcharset161\fprq2 Cambria Greek;}{\fhimajor\f31532\fbidi \froman\fcharset162\fprq2 Cambria Tur;}
//{\fhimajor\f31535\fbidi \froman\fcharset186\fprq2 Cambria Baltic;}{\fhimajor\f31536\fbidi \froman\fcharset163\fprq2 Cambria (Vietnamese);}{\fbimajor\f31538\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
//{\fbimajor\f31539\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fbimajor\f31541\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fbimajor\f31542\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
//{\fbimajor\f31543\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fbimajor\f31544\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fbimajor\f31545\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
//{\fbimajor\f31546\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\flominor\f31548\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\flominor\f31549\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
//{\flominor\f31551\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\flominor\f31552\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\flominor\f31553\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
//{\flominor\f31554\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\flominor\f31555\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\flominor\f31556\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
//{\fdbminor\f31558\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fdbminor\f31559\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fdbminor\f31561\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
//{\fdbminor\f31562\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fdbminor\f31563\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fdbminor\f31564\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
//{\fdbminor\f31565\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fdbminor\f31566\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fhiminor\f31568\fbidi \fswiss\fcharset238\fprq2 Calibri CE;}
//{\fhiminor\f31569\fbidi \fswiss\fcharset204\fprq2 Calibri Cyr;}{\fhiminor\f31571\fbidi \fswiss\fcharset161\fprq2 Calibri Greek;}{\fhiminor\f31572\fbidi \fswiss\fcharset162\fprq2 Calibri Tur;}
//{\fhiminor\f31575\fbidi \fswiss\fcharset186\fprq2 Calibri Baltic;}{\fhiminor\f31576\fbidi \fswiss\fcharset163\fprq2 Calibri (Vietnamese);}{\fbiminor\f31578\fbidi \fswiss\fcharset238\fprq2 Arial CE;}
//{\fbiminor\f31579\fbidi \fswiss\fcharset204\fprq2 Arial Cyr;}{\fbiminor\f31581\fbidi \fswiss\fcharset161\fprq2 Arial Greek;}{\fbiminor\f31582\fbidi \fswiss\fcharset162\fprq2 Arial Tur;}{\fbiminor\f31583\fbidi \fswiss\fcharset177\fprq2 Arial (Hebrew);}
//{\fbiminor\f31584\fbidi \fswiss\fcharset178\fprq2 Arial (Arabic);}{\fbiminor\f31585\fbidi \fswiss\fcharset186\fprq2 Arial Baltic;}{\fbiminor\f31586\fbidi \fswiss\fcharset163\fprq2 Arial (Vietnamese);}
//{\f40\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\f41\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\f43\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\f44\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
//{\f45\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\f46\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\f47\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
//{\f48\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}}{\colortbl;\red0\green0\blue0;\red0\green0\blue255;\red0\green255\blue255;\red0\green255\blue0;\red255\green0\blue255;\red255\green0\blue0;\red255\green255\blue0;
//\red255\green255\blue255;\red0\green0\blue128;\red0\green128\blue128;\red0\green128\blue0;\red128\green0\blue128;\red128\green0\blue0;\red128\green128\blue0;\red128\green128\blue128;\red192\green192\blue192;}{\*\defchp 
//\fs22\loch\af31506\hich\af31506\dbch\af31505 }{\*\defpap \ql \li0\ri0\sa200\sl276\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 }\noqfpromote {\stylesheet{\rtlpar \qr \li0\ri0\sa200\sl276\slmult1
//\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31507\afs22\alang1025 \ltrch\fcs0 \fs22\lang1033\langfe1033\loch\f31506\hich\af31506\dbch\af31505\cgrid\langnp1033\langfenp1033 \snext0 \sqformat \spriority0 Normal;}
//{\*\cs10 \additive \ssemihidden \sunhideused \spriority1 Default Paragraph Font;}{\*
//\ts11\tsrowd\trftsWidthB3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfb3\trpaddfr3\trcbpat1\trcfpat1\tblind0\tblindtype3\tsvertalt\tsbrdrt\tsbrdrl\tsbrdrb\tsbrdrr\tsbrdrdgl\tsbrdrdgr\tsbrdrh\tsbrdrv \ql \li0\ri0\sa200\sl276\slmult1
//\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31507\afs22\alang1025 \ltrch\fcs0 \fs22\lang1033\langfe1033\loch\f31506\hich\af31506\dbch\af31505\cgrid\langnp1033\langfenp1033 \snext11 \ssemihidden \sunhideused 
//Normal Table;}{\s15 \rtlpar \qr \li0\ri0\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af39\afs16\alang1025 \ltrch\fcs0 \fs16\lang1033\langfe1033\loch\f39\hich\af39\dbch\af31505\cgrid\langnp1033\langfenp1033 
//\sbasedon0 \snext15 \slink16 \ssemihidden \sunhideused \styrsid13136662 Balloon Text;}{\*\cs16 \additive \rtlch\fcs1 \af39\afs16 \ltrch\fcs0 \f39\fs16 \sbasedon10 \slink15 \slocked \ssemihidden \styrsid13136662 Balloon Text Char;}}{\*\rsidtbl \rsid23456
//\rsid11871328\rsid13136662\rsid13851809\rsid14296931}{\mmathPr\mmathFont34\mbrkBin0\mbrkBinSub0\msmallFrac0\mdispDef1\mlMargin0\mrMargin0\mdefJc1\mwrapIndent1440\mintLim0\mnaryLim1}{\info{\author Khaled Alsaadi}{\operator Khaled Alsaadi}
//{\creatim\yr2012\mo5\dy6\hr13\min37}{\revtim\yr2012\mo5\dy6\hr13\min37}{\version2}{\edmins0}{\nofpages1}{\nofwords5}{\nofchars33}{\nofcharsws37}{\vern49247}}{\*\xmlnstbl {\xmlns1 http://schemas.microsoft.com/office/word/2003/wordml}}
//\paperw11906\paperh16838\margl1800\margr1800\margt1440\margb1440\gutter0\ltrsect 
//\widowctrl\ftnbj\aenddoc\trackmoves0\trackformatting1\donotembedsysfont1\relyonvml0\donotembedlingdata0\grfdocevents0\validatexml1\showplaceholdtext0\ignoremixedcontent0\saveinvalidxml0\showxmlerrors1\noxlattoyen
//\expshrtn\noultrlspc\dntblnsbdb\nospaceforul\formshade\horzdoc\dgmargin\dghspace180\dgvspace180\dghorigin1800\dgvorigin1440\dghshow1\dgvshow1
//\jexpand\viewkind1\viewscale108\pgbrdrhead\pgbrdrfoot\splytwnine\ftnlytwnine\htmautsp\nolnhtadjtbl\useltbaln\alntblind\lytcalctblwd\lyttblrtgr\lnbrkrule\nobrkwrptbl\snaptogridincell\allowfieldendsel\wrppunct
//\asianbrkrule\rsidroot13851809\newtblstyruls\nogrowautofit\usenormstyforlist\noindnmbrts\felnbrelev\nocxsptable\indrlsweleven\noafcnsttbl\afelev\utinl\hwelev\spltpgpar\notcvasp\notbrkcnstfrctbl\notvatxbx\krnprsnet\cachedcolbal \nouicompat \fet0
//{\*\wgrffmtfilter 2450}\nofeaturethrottle1\ilfomacatclnup0\ltrpar \sectd \ltrsect\linex0\endnhere\sectlinegrid360\sectdefaultcl\sftnbj {\*\pnseclvl1\pnucrm\pnqc\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl2\pnucltr\pnqc\pnstart1\pnindent720\pnhang
//{\pntxta .}}{\*\pnseclvl3\pndec\pnqc\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl4\pnlcltr\pnqc\pnstart1\pnindent720\pnhang {\pntxta )}}{\*\pnseclvl5\pndec\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl6
//\pnlcltr\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl7\pnlcrm\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl8\pnlcltr\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl9
//\pnlcrm\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}\pard\plain \ltrpar\ql \li0\ri0\sa200\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid13136662 \rtlch\fcs1 \af31507\afs22\alang1025 \ltrch\fcs0 
//\fs22\lang1033\langfe1033\loch\af31506\hich\af31506\dbch\af31505\cgrid\langnp1033\langfenp1033 {\rtlch\fcs1 \af37 \ltrch\fcs0 \lang1024\langfe1024\loch\af37\hich\af37\dbch\af37\noproof\insrsid14296931\charrsid14296931 {\*\shppict
//{\pict{\*\picprop\shplid1025{\sp{\sn shapeType}{\sv 75}}{\sp{\sn fFlipH}{\sv 0}}{\sp{\sn fFlipV}{\sv 0}}{\sp{\sn fLockAspectRatio}{\sv 1}}{\sp{\sn fLockPosition}{\sv 0}}{\sp{\sn fLockAgainstSelect}{\sv 0}}{\sp{\sn fLockAgainstGrouping}{\sv 0}}
//{\sp{\sn pictureGray}{\sv 0}}{\sp{\sn pictureBiLevel}{\sv 0}}{\sp{\sn fFilled}{\sv 0}}{\sp{\sn fLine}{\sv 0}}{\sp{\sn wzName}{\sv Picture 1}}{\sp{\sn dhgt}{\sv 251658240}}{\sp{\sn fHidden}{\sv 0}}{\sp{\sn fLayoutInCell}{\sv 1}}}
//\picscalex100\picscaley100\piccropl0\piccropr0\piccropt0\piccropb0\picw847\pich847\picwgoal480\pichgoal480\pngblip\bliptag-772184041{\*\blipuid d1f968174f23215abee21d633ea6d7a8}
//89504e470d0a1a0a0000000d4948445200000020000000200806000000737a7af4000000017352474200aece1ce90000000467414d410000b18f0bfc61050000
//00097048597300000ec300000ec301c76fa86400000163494441545847cd56010ec32008f4e9fdf9b68eaaa81c07b659d6c46459158ee3385bcace73945799d7
//4e9cf4192bf14f814400d43de9ead8814c72bd97c50dbfb7fbfefa9c97c5008613a18d5c7810c81162848b29aafc0d363cfa4646a220ce537e6b5adc33f9f9c4
//7b980121405c76e7fe702036c59ec8e6d1ac45c3ca238c70cd08249dcc1423aab856c41841c633fd3f4c0265c042ea0b5574a49943052cadca56b852df938bf2
//4720d403a6805faa3c0df40aaa0bea9ab007409122004c88ba5a0d8a698ab6a01a88de6805f500c8d9918d2803cd342c20a3c874efadf03701f431b27a0deb51
//2f1e02b00fe46100321d19361080290eb2546e3c3b1a186f4873de2d75c7a7007bc23c15cd8e71f0b5c26bef6556390610d3c4f5ec9e773d78d370df15afab34
//233c31a0badcaa3dec99b6ac7743fe8325e592bac2f9b70d3c625a648f77c1a42f9f3b78da141c4233ba31efe4089dedf63c7e4d870effd9a6376b6bd126ea38cdb60000000049454e44ae426082}}{\nonshppict{\pict\picscalex101\picscaley101\piccropl0\piccropr0\piccropt0\piccropb0
//\picw847\pich847\picwgoal480\pichgoal480\wmetafile8\bliptag-772184041\blipupi95{\*\blipuid d1f968174f23215abee21d633ea6d7a8}010009000003df01000000004101000000000400000003010800050000000b0200000000050000000c0221002100030000001e00040000000701040004000000
//070104000800000026060f000600544e5050060165000000410b8600ee0020002000000000002000200000000000280000002000000020000000010001000000
//0000000000000000000000000000000000000000000000000000ffffff00000000000006e000001ef800007efc0001ffff0007f03fc01fc00fe07f8603f8fe1e
//03fcf87e03fef3fe03defff803cefff003c0ffc003c0ff0e03c0fc7e1bc0f9fe1fc0fbf31fc0ffcf93e0ff3fccf0fcffc33cfbffc09cefffc064bfcf80f87f1f
//03fc3c3e0ff8003e3ff0003fffc0003fff00001ffc00001ff0000007c00041010000410bc6008800200020000000000020002000000000002800000020000000
//200000000100040000000000000000000000000000000000000000000000000000000000ffffff00008000000080800080808000000000000000000000000000
//00000000000000000000000000000000000000000000000000000000000000001111111111111111111111111111111111111111111112212221111111111111
//11111111111224212222211111111111111111111222222122222211111111111111111222220000000222221111111111111222220011111100022222111111
//11122222001111111111000222211111122222200111120111111102222221112222200111122301111111022222221122220111122222011111110222022221
//22221122222220011111110222100221222222222220011111111102221100012222222222001111111111022211111122222222001111111111110222111111
//22222200111122011111110222111111222200111222220111102102221111112222311222222201111022222211111122223122222211001110222222111111
//22222222221122220110112222211111222222221122222220112211222211112222221122222222221111221132221122222122222222222211111121122211
//22212222222202222211111112211211212222222211022221111111022221111222222211102222111111002222221111222211110222211111022222222111
//1111111111222221110022222322111111111111112222200022222222111111111111111122222222222222111111111111111111122222222222111111111111111111111222222222111111111111111111111111122222111111111111110800000026060f000600544e50500701040000002701ffff030000000000}}}
//{\rtlch\fcs1 \af37 \ltrch\fcs0 \loch\af37\hich\af37\dbch\af37\insrsid13136662 \hich\af37\dbch\af37\loch\f37   Souccar for Electronic Industries\line }{\rtlch\fcs1 \af37 \ltrch\fcs0 \loch\af37\hich\af37\dbch\af37\insrsid13851809 
//\par }{\*\themedata 504b030414000600080000002100e9de0fbfff0000001c020000130000005b436f6e74656e745f54797065735d2e786d6cac91cb4ec3301045f748fc83e52d4a
//9cb2400825e982c78ec7a27cc0c8992416c9d8b2a755fbf74cd25442a820166c2cd933f79e3be372bd1f07b5c3989ca74aaff2422b24eb1b475da5df374fd9ad
//5689811a183c61a50f98f4babebc2837878049899a52a57be670674cb23d8e90721f90a4d2fa3802cb35762680fd800ecd7551dc18eb899138e3c943d7e503b6
//b01d583deee5f99824e290b4ba3f364eac4a430883b3c092d4eca8f946c916422ecab927f52ea42b89a1cd59c254f919b0e85e6535d135a8de20f20b8c12c3b0
//0c895fcf6720192de6bf3b9e89ecdbd6596cbcdd8eb28e7c365ecc4ec1ff1460f53fe813d3cc7f5b7f020000ffff0300504b030414000600080000002100a5d6
//a7e7c0000000360100000b0000005f72656c732f2e72656c73848fcf6ac3300c87ef85bd83d17d51d2c31825762fa590432fa37d00e1287f68221bdb1bebdb4f
//c7060abb0884a4eff7a93dfeae8bf9e194e720169aaa06c3e2433fcb68e1763dbf7f82c985a4a725085b787086a37bdbb55fbc50d1a33ccd311ba548b6309512
//0f88d94fbc52ae4264d1c910d24a45db3462247fa791715fd71f989e19e0364cd3f51652d73760ae8fa8c9ffb3c330cc9e4fc17faf2ce545046e37944c69e462
//a1a82fe353bd90a865aad41ed0b5b8f9d6fd010000ffff0300504b0304140006000800000021006b799616830000008a0000001c0000007468656d652f746865
//6d652f7468656d654d616e616765722e786d6c0ccc4d0ac3201040e17da17790d93763bb284562b2cbaebbf600439c1a41c7a0d29fdbd7e5e38337cedf14d59b
//4b0d592c9c070d8a65cd2e88b7f07c2ca71ba8da481cc52c6ce1c715e6e97818c9b48d13df49c873517d23d59085adb5dd20d6b52bd521ef2cdd5eb9246a3d8b
//4757e8d3f729e245eb2b260a0238fd010000ffff0300504b03041400060008000000210030dd4329a8060000a41b0000160000007468656d652f7468656d652f
//7468656d65312e786d6cec594f6fdb3614bf0fd87720746f6327761a07758ad8b19b2d4d1bc46e871e698996d850a240d2497d1bdae38001c3ba618715d86d87
//615b8116d8a5fb34d93a6c1dd0afb0475292c5585e9236d88aad3e2412f9e3fbff1e1fa9abd7eec70c1d1221294fda5efd72cd4324f1794093b0eddd1ef62fad
//79482a9c0498f184b4bd2991deb58df7dfbb8ad755446282607d22d771db8b944ad79796a40fc3585ee62949606ecc458c15bc8a702910f808e8c66c69b9565b
//5d8a314d3c94e018c8de1a8fa94fd05093f43672e23d06af89927ac06762a049136785c10607758d9053d965021d62d6f6804fc08f86e4bef210c352c144dbab
//999fb7b4717509af678b985ab0b6b4ae6f7ed9ba6c4170b06c788a705430adf71bad2b5b057d03606a1ed7ebf5babd7a41cf00b0ef83a6569632cd467faddec9
//699640f6719e76b7d6ac355c7c89feca9cccad4ea7d36c65b258a206641f1b73f8b5da6a6373d9c11b90c537e7f08dce66b7bbeae00dc8e257e7f0fd2badd586
//8b37a088d1e4600ead1ddaef67d40bc898b3ed4af81ac0d76a197c86826828a24bb318f3442d8ab518dfe3a20f000d6458d104a9694ac6d88728eee2782428d6
//0cf03ac1a5193be4cbb921cd0b495fd054b5bd0f530c1931a3f7eaf9f7af9e3f45c70f9e1d3ff8e9f8e1c3e3073f5a42ceaa6d9c84e5552fbffdeccfc71fa33f
//9e7ef3f2d117d57859c6fffac327bffcfc793510d26726ce8b2f9ffcf6ecc98baf3efdfdbb4715f04d814765f890c644a29be408edf3181433567125272371be
//15c308d3f28acd249438c19a4b05fd9e8a1cf4cd296699771c393ac4b5e01d01e5a30a787d72cf1178108989a2159c77a2d801ee72ce3a5c545a6147f32a9979
//3849c26ae66252c6ed637c58c5bb8b13c7bfbd490a75330f4b47f16e441c31f7184e140e494214d273fc80900aedee52ead87597fa824b3e56e82e451d4c2b4d
//32a423279a668bb6690c7e9956e90cfe766cb37b077538abd27a8b1cba48c80acc2a841f12e698f13a9e281c57911ce298950d7e03aba84ac8c154f8655c4f2a
//f074481847bd804859b5e696007d4b4edfc150b12addbecba6b18b148a1e54d1bc81392f23b7f84137c2715a851dd0242a633f900710a218ed715505dfe56e86
//e877f0034e16bafb0e258ebb4faf06b769e888340b103d331115bebc4eb813bf83291b63624a0d1475a756c734f9bbc2cd28546ecbe1e20a3794ca175f3fae90
//fb6d2dd99bb07b55e5ccf68942bd0877b23c77b908e8db5f9db7f024d9239010f35bd4bbe2fcae387bfff9e2bc289f2fbe24cfaa301468dd8bd846dbb4ddf1c2
//ae7b4c191ba8292337a469bc25ec3d411f06f53a73e224c5292c8de0516732307070a1c0660d125c7d44553488700a4d7bddd3444299910e254ab984c3a219ae
//a4adf1d0f82b7bd46cea4388ad1c12ab5d1ed8e1153d9c9f350a3246aad01c6873462b9ac05999ad5cc988826eafc3acae853a33b7ba11cd1445875ba1b236b1
//399483c90bd560b0b0263435085a21b0f22a9cf9356b38ec6046026d77eba3dc2dc60b17e92219e180643ed27acffba86e9c94c7ca9c225a0f1b0cfae0788ad5
//4adc5a9aec1b703b8b93caec1a0bd8e5de7b132fe5113cf312503b998e2c2927274bd051db6b35979b1ef271daf6c6704e86c73805af4bdd476216c26593af84
//0dfb5393d964f9cc9bad5c313709ea70f561ed3ea7b053075221d51696910d0d339585004b34272bff7213cc7a510a5454a3b349b1b206c1f0af490176745d4b
//c663e2abb2b34b23da76f6352ba57ca2881844c1111ab189d8c7e07e1daaa04f40255c77988aa05fe06e4e5bdb4cb9c5394bbaf28d98c1d971ccd20867e556a7
//689ec9166e0a522183792b8907ba55ca6e943bbf2a26e52f48957218ffcf54d1fb09dc3eac04da033e5c0d0b8c74a6b43d2e54c4a10aa511f5fb021a07533b20
//5ae07e17a621a8e082dafc17e450ffb739676998b48643a4daa7211214f623150942f6a02c99e83b85583ddbbb2c4996113211551257a656ec1139246ca86be0
//aadedb3d1441a89b6a929501833b197fee7b9641a3503739e57c732a59b1f7da1cf8a73b1f9bcca0945b874d4393dbbf10b1680f66bbaa5d6f96e77b6f59113d
//316bb31a795600b3d256d0cad2fe354538e7566b2bd69cc6cbcd5c38f0e2bcc63058344429dc2121fd07f63f2a7c66bf76e80d75c8f7a1b622f878a18941d840
//545fb28d07d205d20e8ea071b283369834296bdaac75d256cb37eb0bee740bbe278cad253b8bbfcf69eca23973d939b97891c6ce2cecd8da8e2d343578f6648a
//c2d0383fc818c798cf64e52f597c740f1cbd05df0c264c49134cf09d4a60e8a107260f20f92d47b374e32f000000ffff0300504b030414000600080000002100
//0dd1909fb60000001b010000270000007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73848f4d0ac2301484f7
//8277086f6fd3ba109126dd88d0add40384e4350d363f2451eced0dae2c082e8761be9969bb979dc9136332de3168aa1a083ae995719ac16db8ec8e4052164e89
//d93b64b060828e6f37ed1567914b284d262452282e3198720e274a939cd08a54f980ae38a38f56e422a3a641c8bbd048f7757da0f19b017cc524bd62107bd500
//1996509affb3fd381a89672f1f165dfe514173d9850528a2c6cce0239baa4c04ca5bbabac4df000000ffff0300504b01022d0014000600080000002100e9de0f
//bfff0000001c0200001300000000000000000000000000000000005b436f6e74656e745f54797065735d2e786d6c504b01022d0014000600080000002100a5d6
//a7e7c0000000360100000b00000000000000000000000000300100005f72656c732f2e72656c73504b01022d00140006000800000021006b799616830000008a
//0000001c00000000000000000000000000190200007468656d652f7468656d652f7468656d654d616e616765722e786d6c504b01022d00140006000800000021
//0030dd4329a8060000a41b00001600000000000000000000000000d60200007468656d652f7468656d652f7468656d65312e786d6c504b01022d001400060008
//00000021000dd1909fb60000001b0100002700000000000000000000000000b20900007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73504b050600000000050005005d010000ad0a00000000}
//{\*\colorschememapping 3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d225554462d3822207374616e64616c6f6e653d22796573223f3e0d0a3c613a636c724d
//617020786d6c6e733a613d22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f64726177696e676d6c2f323030362f6d6169
//6e22206267313d226c743122207478313d22646b3122206267323d226c743222207478323d22646b322220616363656e74313d22616363656e74312220616363
//656e74323d22616363656e74322220616363656e74333d22616363656e74332220616363656e74343d22616363656e74342220616363656e74353d22616363656e74352220616363656e74363d22616363656e74362220686c696e6b3d22686c696e6b2220666f6c486c696e6b3d22666f6c486c696e6b222f3e}
//{\*\latentstyles\lsdstimax267\lsdlockeddef0\lsdsemihiddendef1\lsdunhideuseddef1\lsdqformatdef0\lsdprioritydef99{\lsdlockedexcept \lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority0 \lsdlocked0 Normal;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 1;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 2;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 3;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 4;
//\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 5;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 6;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 7;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 8;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 9;
//\lsdpriority39 \lsdlocked0 toc 1;\lsdpriority39 \lsdlocked0 toc 2;\lsdpriority39 \lsdlocked0 toc 3;\lsdpriority39 \lsdlocked0 toc 4;\lsdpriority39 \lsdlocked0 toc 5;\lsdpriority39 \lsdlocked0 toc 6;\lsdpriority39 \lsdlocked0 toc 7;
//\lsdpriority39 \lsdlocked0 toc 8;\lsdpriority39 \lsdlocked0 toc 9;\lsdqformat1 \lsdpriority35 \lsdlocked0 caption;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority10 \lsdlocked0 Title;\lsdpriority1 \lsdlocked0 Default Paragraph Font;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority11 \lsdlocked0 Subtitle;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority22 \lsdlocked0 Strong;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority20 \lsdlocked0 Emphasis;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority59 \lsdlocked0 Table Grid;\lsdunhideused0 \lsdlocked0 Placeholder Text;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority1 \lsdlocked0 No Spacing;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 1;\lsdunhideused0 \lsdlocked0 Revision;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority34 \lsdlocked0 List Paragraph;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority29 \lsdlocked0 Quote;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority30 \lsdlocked0 Intense Quote;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 4;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 4;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 4;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 4;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority19 \lsdlocked0 Subtle Emphasis;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority21 \lsdlocked0 Intense Emphasis;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority31 \lsdlocked0 Subtle Reference;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority32 \lsdlocked0 Intense Reference;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority33 \lsdlocked0 Book Title;\lsdpriority37 \lsdlocked0 Bibliography;\lsdqformat1 \lsdpriority39 \lsdlocked0 TOC Heading;}}{\*\datastore 010500000200000018000000
//4d73786d6c322e534158584d4c5265616465722e362e3000000000000000000000060000
//d0cf11e0a1b11ae1000000000000000000000000000000003e000300feff090006000000000000000000000001000000010000000000000000100000feffffff00000000feffffff0000000000000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//fffffffffffffffffdfffffffeffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffffffffffff0c6ad98892f1d411a65f0040963251e500000000000000000000000010e3
//62a67c2bcd01feffffff00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff00000000000000000000000000000000000000000000000000000000
//00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff0000000000000000000000000000000000000000000000000000
//000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff000000000000000000000000000000000000000000000000
//0000000000000000000000000000000000000000000000000105000000000000}}";

//            xrRichText1.Rtf = rtf;

//            rtf =
//                @"{\rtf1\adeflang1025\ansi\ansicpg1256\uc1\adeff37\deff0\stshfdbch31506\stshfloch37\stshfhich37\stshfbi38\deflang1033\deflangfe1033\themelang1033\themelangfe0\themelangcs1025{\fonttbl{\f0\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
//{\f34\fbidi \froman\fcharset1\fprq2{\*\panose 02040503050406030204}Cambria Math;}{\f37\fbidi \fswiss\fcharset0\fprq2{\*\panose 020f0502020204030204}Calibri;}{\f38\fbidi \froman\fcharset0\fprq2{\*\panose 00000000000000000000}Simplified Arabic;}
//{\f39\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0604030504040204}Tahoma;}{\f40\fbidi \froman\fcharset2\fprq2{\*\panose 05030102010509060703}Webdings;}{\flomajor\f31500\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
//{\fdbmajor\f31501\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhimajor\f31502\fbidi \froman\fcharset0\fprq2{\*\panose 02040503050406030204}Cambria;}
//{\fbimajor\f31503\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\flominor\f31504\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
//{\fdbminor\f31505\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhiminor\f31506\fbidi \fswiss\fcharset0\fprq2{\*\panose 020f0502020204030204}Calibri;}
//{\fbiminor\f31507\fbidi \fswiss\fcharset0\fprq2{\*\panose 020b0604020202020204}Arial;}{\f41\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\f42\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
//{\f44\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\f45\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\f46\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\f47\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
//{\f48\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\f49\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\f411\fbidi \fswiss\fcharset238\fprq2 Calibri CE;}{\f412\fbidi \fswiss\fcharset204\fprq2 Calibri Cyr;}
//{\f414\fbidi \fswiss\fcharset161\fprq2 Calibri Greek;}{\f415\fbidi \fswiss\fcharset162\fprq2 Calibri Tur;}{\f418\fbidi \fswiss\fcharset186\fprq2 Calibri Baltic;}{\f419\fbidi \fswiss\fcharset163\fprq2 Calibri (Vietnamese);}
//{\f427\fbidi \froman\fcharset178\fprq2 Simplified Arabic (Arabic);}{\f431\fbidi \fswiss\fcharset238\fprq2 Tahoma CE;}{\f432\fbidi \fswiss\fcharset204\fprq2 Tahoma Cyr;}{\f434\fbidi \fswiss\fcharset161\fprq2 Tahoma Greek;}
//{\f435\fbidi \fswiss\fcharset162\fprq2 Tahoma Tur;}{\f436\fbidi \fswiss\fcharset177\fprq2 Tahoma (Hebrew);}{\f437\fbidi \fswiss\fcharset178\fprq2 Tahoma (Arabic);}{\f438\fbidi \fswiss\fcharset186\fprq2 Tahoma Baltic;}
//{\f439\fbidi \fswiss\fcharset163\fprq2 Tahoma (Vietnamese);}{\f440\fbidi \fswiss\fcharset222\fprq2 Tahoma (Thai);}{\flomajor\f31508\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\flomajor\f31509\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
//{\flomajor\f31511\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\flomajor\f31512\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\flomajor\f31513\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
//{\flomajor\f31514\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\flomajor\f31515\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\flomajor\f31516\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
//{\fdbmajor\f31518\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fdbmajor\f31519\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fdbmajor\f31521\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
//{\fdbmajor\f31522\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fdbmajor\f31523\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fdbmajor\f31524\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
//{\fdbmajor\f31525\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fdbmajor\f31526\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fhimajor\f31528\fbidi \froman\fcharset238\fprq2 Cambria CE;}
//{\fhimajor\f31529\fbidi \froman\fcharset204\fprq2 Cambria Cyr;}{\fhimajor\f31531\fbidi \froman\fcharset161\fprq2 Cambria Greek;}{\fhimajor\f31532\fbidi \froman\fcharset162\fprq2 Cambria Tur;}
//{\fhimajor\f31535\fbidi \froman\fcharset186\fprq2 Cambria Baltic;}{\fhimajor\f31536\fbidi \froman\fcharset163\fprq2 Cambria (Vietnamese);}{\fbimajor\f31538\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
//{\fbimajor\f31539\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fbimajor\f31541\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fbimajor\f31542\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
//{\fbimajor\f31543\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fbimajor\f31544\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fbimajor\f31545\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
//{\fbimajor\f31546\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\flominor\f31548\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\flominor\f31549\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
//{\flominor\f31551\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\flominor\f31552\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\flominor\f31553\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
//{\flominor\f31554\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\flominor\f31555\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\flominor\f31556\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
//{\fdbminor\f31558\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fdbminor\f31559\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fdbminor\f31561\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
//{\fdbminor\f31562\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fdbminor\f31563\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fdbminor\f31564\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
//{\fdbminor\f31565\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fdbminor\f31566\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fhiminor\f31568\fbidi \fswiss\fcharset238\fprq2 Calibri CE;}
//{\fhiminor\f31569\fbidi \fswiss\fcharset204\fprq2 Calibri Cyr;}{\fhiminor\f31571\fbidi \fswiss\fcharset161\fprq2 Calibri Greek;}{\fhiminor\f31572\fbidi \fswiss\fcharset162\fprq2 Calibri Tur;}
//{\fhiminor\f31575\fbidi \fswiss\fcharset186\fprq2 Calibri Baltic;}{\fhiminor\f31576\fbidi \fswiss\fcharset163\fprq2 Calibri (Vietnamese);}{\fbiminor\f31578\fbidi \fswiss\fcharset238\fprq2 Arial CE;}
//{\fbiminor\f31579\fbidi \fswiss\fcharset204\fprq2 Arial Cyr;}{\fbiminor\f31581\fbidi \fswiss\fcharset161\fprq2 Arial Greek;}{\fbiminor\f31582\fbidi \fswiss\fcharset162\fprq2 Arial Tur;}{\fbiminor\f31583\fbidi \fswiss\fcharset177\fprq2 Arial (Hebrew);}
//{\fbiminor\f31584\fbidi \fswiss\fcharset178\fprq2 Arial (Arabic);}{\fbiminor\f31585\fbidi \fswiss\fcharset186\fprq2 Arial Baltic;}{\fbiminor\f31586\fbidi \fswiss\fcharset163\fprq2 Arial (Vietnamese);}}{\colortbl;\red0\green0\blue0;\red0\green0\blue255;
//\red0\green255\blue255;\red0\green255\blue0;\red255\green0\blue255;\red255\green0\blue0;\red255\green255\blue0;\red255\green255\blue255;\red0\green0\blue128;\red0\green128\blue128;\red0\green128\blue0;\red128\green0\blue128;\red128\green0\blue0;
//\red128\green128\blue0;\red128\green128\blue128;\red192\green192\blue192;\red0\green103\blue75;}{\*\defchp \f37\fs22 }{\*\defpap \ql \li0\ri0\sa200\sl276\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 }
//\noqfpromote {\stylesheet{\ql \li0\ri0\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af37\afs22\alang1025 \ltrch\fcs0 \f37\fs22\lang1033\langfe1033\cgrid\langnp1033\langfenp1033 
//\snext0 \sqformat \spriority0 \styrsid8601140 Normal;}{\*\cs10 \additive \ssemihidden \sunhideused \spriority1 Default Paragraph Font;}{\*
//\ts11\tsrowd\trftsWidthB3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfb3\trpaddfr3\trcbpat1\trcfpat1\tblind0\tblindtype3\tsvertalt\tsbrdrt\tsbrdrl\tsbrdrb\tsbrdrr\tsbrdrdgl\tsbrdrdgr\tsbrdrh\tsbrdrv \ql \li0\ri0\sa200\sl276\slmult1
//\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af38\afs22\alang1025 \ltrch\fcs0 \f37\fs22\lang1033\langfe1033\cgrid\langnp1033\langfenp1033 \snext11 \ssemihidden \sunhideused Normal Table;}}{\*\pgptbl {\pgp\ipgp0
//\itap0\li0\ri0\sb0\sa0}}{\*\rsidtbl \rsid8601140\rsid8658627\rsid11087859\rsid16414704}{\mmathPr\mmathFont34\mbrkBin0\mbrkBinSub0\msmallFrac0\mdispDef1\mlMargin0\mrMargin0\mdefJc1\mwrapIndent1440\mintLim0\mnaryLim1}{\info{\author Khaled Alsaadi}
//{\operator Khaled Alsaadi}{\creatim\yr2012\mo5\dy6\hr13\min46}{\revtim\yr2012\mo5\dy6\hr13\min46}{\version2}{\edmins0}{\nofpages1}{\nofwords12}{\nofchars70}{\nofcharsws81}{\vern49247}}{\*\xmlnstbl {\xmlns1 http://schemas.microsoft.com/office/word/2003/wor
//dml}}\paperw12240\paperh15840\margl1800\margr1800\margt1440\margb1440\gutter0\ltrsect 
//\widowctrl\ftnbj\aenddoc\trackmoves0\trackformatting1\donotembedsysfont1\relyonvml0\donotembedlingdata0\grfdocevents0\validatexml1\showplaceholdtext0\ignoremixedcontent0\saveinvalidxml0\showxmlerrors1\noxlattoyen
//\expshrtn\noultrlspc\dntblnsbdb\nospaceforul\formshade\horzdoc\dgmargin\dghspace180\dgvspace180\dghorigin1800\dgvorigin1440\dghshow1\dgvshow1
//\jexpand\viewkind1\viewscale100\pgbrdrhead\pgbrdrfoot\splytwnine\ftnlytwnine\htmautsp\nolnhtadjtbl\useltbaln\alntblind\lytcalctblwd\lyttblrtgr\lnbrkrule\nobrkwrptbl\snaptogridincell\allowfieldendsel\wrppunct
//\asianbrkrule\rsidroot8658627\newtblstyruls\nogrowautofit\usenormstyforlist\noindnmbrts\felnbrelev\nocxsptable\indrlsweleven\noafcnsttbl\afelev\utinl\hwelev\spltpgpar\notcvasp\notbrkcnstfrctbl\notvatxbx\krnprsnet\cachedcolbal \nouicompat \fet0
//{\*\wgrffmtfilter 2450}\nofeaturethrottle1\ilfomacatclnup0\ltrpar \sectd \ltrsect\linex0\endnhere\sectlinegrid360\sectdefaultcl\sftnbj {\*\pnseclvl1\pnucrm\pnqc\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl2\pnucltr\pnqc\pnstart1\pnindent720\pnhang
//{\pntxta .}}{\*\pnseclvl3\pndec\pnqc\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl4\pnlcltr\pnqc\pnstart1\pnindent720\pnhang {\pntxta )}}{\*\pnseclvl5\pndec\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl6
//\pnlcltr\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl7\pnlcrm\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl8\pnlcltr\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl9
//\pnlcrm\pnqc\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}\pard\plain \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid8601140 \rtlch\fcs1 \af37\afs22\alang1025 
//\ltrch\fcs0 \f37\fs22\lang1033\langfe1033\cgrid\langnp1033\langfenp1033 {\rtlch\fcs1 \ab\af37\afs44 \ltrch\fcs0 \b\f40\fs44\cf17\insrsid8601140 {\*\bkmkstart _GoBack}{\*\bkmkend _GoBack}\'50}{\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\insrsid8601140  }{
//\rtlch\fcs1 \ab\af39\afs15 \ltrch\fcs0 \b\f39\fs15\cf17\insrsid8601140 Please consider your environmental responsibility before printing this e-mail}{\rtlch\fcs1 \af0\afs24 \ltrch\fcs0 \f0\fs24\insrsid8601140  }{\rtlch\fcs1 \af0 \ltrch\fcs0 
//\f0\insrsid8601140 
//\par }\pard \ltrpar\ql \li0\ri0\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid11087859 {\ltrch\fcs1 \rtlch\fcs0 \f37\lang1025\insrsid11087859 
//\par }{\*\themedata 504b030414000600080000002100e9de0fbfff0000001c020000130000005b436f6e74656e745f54797065735d2e786d6cac91cb4ec3301045f748fc83e52d4a
//9cb2400825e982c78ec7a27cc0c8992416c9d8b2a755fbf74cd25442a820166c2cd933f79e3be372bd1f07b5c3989ca74aaff2422b24eb1b475da5df374fd9ad
//5689811a183c61a50f98f4babebc2837878049899a52a57be670674cb23d8e90721f90a4d2fa3802cb35762680fd800ecd7551dc18eb899138e3c943d7e503b6
//b01d583deee5f99824e290b4ba3f364eac4a430883b3c092d4eca8f946c916422ecab927f52ea42b89a1cd59c254f919b0e85e6535d135a8de20f20b8c12c3b0
//0c895fcf6720192de6bf3b9e89ecdbd6596cbcdd8eb28e7c365ecc4ec1ff1460f53fe813d3cc7f5b7f020000ffff0300504b030414000600080000002100a5d6
//a7e7c0000000360100000b0000005f72656c732f2e72656c73848fcf6ac3300c87ef85bd83d17d51d2c31825762fa590432fa37d00e1287f68221bdb1bebdb4f
//c7060abb0884a4eff7a93dfeae8bf9e194e720169aaa06c3e2433fcb68e1763dbf7f82c985a4a725085b787086a37bdbb55fbc50d1a33ccd311ba548b6309512
//0f88d94fbc52ae4264d1c910d24a45db3462247fa791715fd71f989e19e0364cd3f51652d73760ae8fa8c9ffb3c330cc9e4fc17faf2ce545046e37944c69e462
//a1a82fe353bd90a865aad41ed0b5b8f9d6fd010000ffff0300504b0304140006000800000021006b799616830000008a0000001c0000007468656d652f746865
//6d652f7468656d654d616e616765722e786d6c0ccc4d0ac3201040e17da17790d93763bb284562b2cbaebbf600439c1a41c7a0d29fdbd7e5e38337cedf14d59b
//4b0d592c9c070d8a65cd2e88b7f07c2ca71ba8da481cc52c6ce1c715e6e97818c9b48d13df49c873517d23d59085adb5dd20d6b52bd521ef2cdd5eb9246a3d8b
//4757e8d3f729e245eb2b260a0238fd010000ffff0300504b03041400060008000000210030dd4329a8060000a41b0000160000007468656d652f7468656d652f
//7468656d65312e786d6cec594f6fdb3614bf0fd87720746f6327761a07758ad8b19b2d4d1bc46e871e698996d850a240d2497d1bdae38001c3ba618715d86d87
//615b8116d8a5fb34d93a6c1dd0afb0475292c5585e9236d88aad3e2412f9e3fbff1e1fa9abd7eec70c1d1221294fda5efd72cd4324f1794093b0eddd1ef62fad
//79482a9c0498f184b4bd2991deb58df7dfbb8ad755446282607d22d771db8b944ad79796a40fc3585ee62949606ecc458c15bc8a702910f808e8c66c69b9565b
//5d8a314d3c94e018c8de1a8fa94fd05093f43672e23d06af89927ac06762a049136785c10607758d9053d965021d62d6f6804fc08f86e4bef210c352c144dbab
//999fb7b4717509af678b985ab0b6b4ae6f7ed9ba6c4170b06c788a705430adf71bad2b5b057d03606a1ed7ebf5babd7a41cf00b0ef83a6569632cd467faddec9
//699640f6719e76b7d6ac355c7c89feca9cccad4ea7d36c65b258a206641f1b73f8b5da6a6373d9c11b90c537e7f08dce66b7bbeae00dc8e257e7f0fd2badd586
//8b37a088d1e4600ead1ddaef67d40bc898b3ed4af81ac0d76a197c86826828a24bb318f3442d8ab518dfe3a20f000d6458d104a9694ac6d88728eee2782428d6
//0cf03ac1a5193be4cbb921cd0b495fd054b5bd0f530c1931a3f7eaf9f7af9e3f45c70f9e1d3ff8e9f8e1c3e3073f5a42ceaa6d9c84e5552fbffdeccfc71fa33f
//9e7ef3f2d117d57859c6fffac327bffcfc793510d26726ce8b2f9ffcf6ecc98baf3efdfdbb4715f04d814765f890c644a29be408edf3181433567125272371be
//15c308d3f28acd249438c19a4b05fd9e8a1cf4cd296699771c393ac4b5e01d01e5a30a787d72cf1178108989a2159c77a2d801ee72ce3a5c545a6147f32a9979
//3849c26ae66252c6ed637c58c5bb8b13c7bfbd490a75330f4b47f16e441c31f7184e140e494214d273fc80900aedee52ead87597fa824b3e56e82e451d4c2b4d
//32a423279a668bb6690c7e9956e90cfe766cb37b077538abd27a8b1cba48c80acc2a841f12e698f13a9e281c57911ce298950d7e03aba84ac8c154f8655c4f2a
//f074481847bd804859b5e696007d4b4edfc150b12addbecba6b18b148a1e54d1bc81392f23b7f84137c2715a851dd0242a633f900710a218ed715505dfe56e86
//e877f0034e16bafb0e258ebb4faf06b769e888340b103d331115bebc4eb813bf83291b63624a0d1475a756c734f9bbc2cd28546ecbe1e20a3794ca175f3fae90
//fb6d2dd99bb07b55e5ccf68942bd0877b23c77b908e8db5f9db7f024d9239010f35bd4bbe2fcae387bfff9e2bc289f2fbe24cfaa301468dd8bd846dbb4ddf1c2
//ae7b4c191ba8292337a469bc25ec3d411f06f53a73e224c5292c8de0516732307070a1c0660d125c7d44553488700a4d7bddd3444299910e254ab984c3a219ae
//a4adf1d0f82b7bd46cea4388ad1c12ab5d1ed8e1153d9c9f350a3246aad01c6873462b9ac05999ad5cc988826eafc3acae853a33b7ba11cd1445875ba1b236b1
//399483c90bd560b0b0263435085a21b0f22a9cf9356b38ec6046026d77eba3dc2dc60b17e92219e180643ed27acffba86e9c94c7ca9c225a0f1b0cfae0788ad5
//4adc5a9aec1b703b8b93caec1a0bd8e5de7b132fe5113cf312503b998e2c2927274bd051db6b35979b1ef271daf6c6704e86c73805af4bdd476216c26593af84
//0dfb5393d964f9cc9bad5c313709ea70f561ed3ea7b053075221d51696910d0d339585004b34272bff7213cc7a510a5454a3b349b1b206c1f0af490176745d4b
//c663e2abb2b34b23da76f6352ba57ca2881844c1111ab189d8c7e07e1daaa04f40255c77988aa05fe06e4e5bdb4cb9c5394bbaf28d98c1d971ccd20867e556a7
//689ec9166e0a522183792b8907ba55ca6e943bbf2a26e52f48957218ffcf54d1fb09dc3eac04da033e5c0d0b8c74a6b43d2e54c4a10aa511f5fb021a07533b20
//5ae07e17a621a8e082dafc17e450ffb739676998b48643a4daa7211214f623150942f6a02c99e83b85583ddbbb2c4996113211551257a656ec1139246ca86be0
//aadedb3d1441a89b6a929501833b197fee7b9641a3503739e57c732a59b1f7da1cf8a73b1f9bcca0945b874d4393dbbf10b1680f66bbaa5d6f96e77b6f59113d
//316bb31a795600b3d256d0cad2fe354538e7566b2bd69cc6cbcd5c38f0e2bcc63058344429dc2121fd07f63f2a7c66bf76e80d75c8f7a1b622f878a18941d840
//545fb28d07d205d20e8ea071b283369834296bdaac75d256cb37eb0bee740bbe278cad253b8bbfcf69eca23973d939b97891c6ce2cecd8da8e2d343578f6648a
//c2d0383fc818c798cf64e52f597c740f1cbd05df0c264c49134cf09d4a60e8a107260f20f92d47b374e32f000000ffff0300504b030414000600080000002100
//0dd1909fb60000001b010000270000007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73848f4d0ac2301484f7
//8277086f6fd3ba109126dd88d0add40384e4350d363f2451eced0dae2c082e8761be9969bb979dc9136332de3168aa1a083ae995719ac16db8ec8e4052164e89
//d93b64b060828e6f37ed1567914b284d262452282e3198720e274a939cd08a54f980ae38a38f56e422a3a641c8bbd048f7757da0f19b017cc524bd62107bd500
//1996509affb3fd381a89672f1f165dfe514173d9850528a2c6cce0239baa4c04ca5bbabac4df000000ffff0300504b01022d0014000600080000002100e9de0f
//bfff0000001c0200001300000000000000000000000000000000005b436f6e74656e745f54797065735d2e786d6c504b01022d0014000600080000002100a5d6
//a7e7c0000000360100000b00000000000000000000000000300100005f72656c732f2e72656c73504b01022d00140006000800000021006b799616830000008a
//0000001c00000000000000000000000000190200007468656d652f7468656d652f7468656d654d616e616765722e786d6c504b01022d00140006000800000021
//0030dd4329a8060000a41b00001600000000000000000000000000d60200007468656d652f7468656d652f7468656d65312e786d6c504b01022d001400060008
//00000021000dd1909fb60000001b0100002700000000000000000000000000b20900007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73504b050600000000050005005d010000ad0a00000000}
//{\*\colorschememapping 3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d225554462d3822207374616e64616c6f6e653d22796573223f3e0d0a3c613a636c724d
//617020786d6c6e733a613d22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f64726177696e676d6c2f323030362f6d6169
//6e22206267313d226c743122207478313d22646b3122206267323d226c743222207478323d22646b322220616363656e74313d22616363656e74312220616363
//656e74323d22616363656e74322220616363656e74333d22616363656e74332220616363656e74343d22616363656e74342220616363656e74353d22616363656e74352220616363656e74363d22616363656e74362220686c696e6b3d22686c696e6b2220666f6c486c696e6b3d22666f6c486c696e6b222f3e}
//{\*\latentstyles\lsdstimax267\lsdlockeddef0\lsdsemihiddendef1\lsdunhideuseddef1\lsdqformatdef0\lsdprioritydef99{\lsdlockedexcept \lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority0 \lsdlocked0 Normal;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 1;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 2;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 3;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 4;
//\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 5;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 6;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 7;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 8;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 9;
//\lsdpriority39 \lsdlocked0 toc 1;\lsdpriority39 \lsdlocked0 toc 2;\lsdpriority39 \lsdlocked0 toc 3;\lsdpriority39 \lsdlocked0 toc 4;\lsdpriority39 \lsdlocked0 toc 5;\lsdpriority39 \lsdlocked0 toc 6;\lsdpriority39 \lsdlocked0 toc 7;
//\lsdpriority39 \lsdlocked0 toc 8;\lsdpriority39 \lsdlocked0 toc 9;\lsdqformat1 \lsdpriority35 \lsdlocked0 caption;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority10 \lsdlocked0 Title;\lsdpriority1 \lsdlocked0 Default Paragraph Font;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority11 \lsdlocked0 Subtitle;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority22 \lsdlocked0 Strong;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority20 \lsdlocked0 Emphasis;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority59 \lsdlocked0 Table Grid;\lsdunhideused0 \lsdlocked0 Placeholder Text;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority1 \lsdlocked0 No Spacing;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 1;\lsdunhideused0 \lsdlocked0 Revision;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority34 \lsdlocked0 List Paragraph;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority29 \lsdlocked0 Quote;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority30 \lsdlocked0 Intense Quote;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 1;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 1;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 2;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 2;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 3;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 3;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 4;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 4;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 4;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 4;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 4;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 5;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 5;\lsdsemihidden0 \lsdunhideused0 \lsdpriority60 \lsdlocked0 Light Shading Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority61 \lsdlocked0 Light List Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority62 \lsdlocked0 Light Grid Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority65 \lsdlocked0 Medium List 1 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority66 \lsdlocked0 Medium List 2 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority70 \lsdlocked0 Dark List Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdpriority71 \lsdlocked0 Colorful Shading Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority72 \lsdlocked0 Colorful List Accent 6;\lsdsemihidden0 \lsdunhideused0 \lsdpriority73 \lsdlocked0 Colorful Grid Accent 6;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority19 \lsdlocked0 Subtle Emphasis;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority21 \lsdlocked0 Intense Emphasis;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority31 \lsdlocked0 Subtle Reference;\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority32 \lsdlocked0 Intense Reference;
//\lsdsemihidden0 \lsdunhideused0 \lsdqformat1 \lsdpriority33 \lsdlocked0 Book Title;\lsdpriority37 \lsdlocked0 Bibliography;\lsdqformat1 \lsdpriority39 \lsdlocked0 TOC Heading;}}{\*\datastore 010500000200000018000000
//4d73786d6c322e534158584d4c5265616465722e362e3000000000000000000000060000
//d0cf11e0a1b11ae1000000000000000000000000000000003e000300feff090006000000000000000000000001000000010000000000000000100000feffffff00000000feffffff0000000000000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//fffffffffffffffffdfffffffeffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
//ffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffffffffffff0c6ad98892f1d411a65f0040963251e50000000000000000000000001088
//35ec7d2bcd01feffffff00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff00000000000000000000000000000000000000000000000000000000
//00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff0000000000000000000000000000000000000000000000000000
//000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff000000000000000000000000000000000000000000000000
//0000000000000000000000000000000000000000000000000105000000000000}}";

//            xrRichText2.Rtf = rtf;
//        }
//    }
//}