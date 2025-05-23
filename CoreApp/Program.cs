﻿// See https://aka.ms/new-console-template for more information
using CoreApp.com.test;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Threading.Tasks;

class Program
{
    public delegate void addNumber(int a, int b);
    public delegate void subNumber(int a, int b);

    //multicasting delegate
    public delegate void rectDelegate(double height, double width);

    // Declaring the delegate for predicate
    public delegate bool predicate_test(string msg);

    static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        //Plus One
        //int[] digits1 = { 1, 2, 3 };
        int[] digits1 = { 9 };
        //int[] digits1 = { 9, 8,7,6,5,4,3,2,1,0};
        var plusOne = ProblemAndSolutionOne.PlusOne(digits1);
        Console.WriteLine("[{0}]", string.Join(",", plusOne));


        //LengthOfLastWord
        //string sss = "   fly me   to   the moon  ";
        //string sss = "Hello World";
        string sss = "luffy is still joyboy";
        var sssT = ProblemAndSolutionOne.LengthOfLastWord(sss);
        Console.WriteLine("{0}", sssT);



        //Search Insert Position
        //int[] nums11 = { 1, 3, 5,6 };
        //int target11 = 5;
        int[] nums11 = { 1, 3, 5, 6 };
        //int target11 = 2;
        int target11 = 7;
        var insertPosition = ProblemAndSolutionOne.SearchInsert(nums11, target11);
        Console.WriteLine("{0}", insertPosition);

        //Find the Index of the First Occurrence in a String
        string haystack = "sadbutsad";
        string needle = "sad";
        var findIndex = ProblemAndSolutionOne.StrStr(haystack, needle);
        Console.WriteLine("{0}", findIndex);

        //RemoveElement
        int[] removeFromArr = { 3, 2, 2, 3 };
        int removeInt = 3;
        var removeIntRes = ProblemAndSolutionOne.RemoveElement(removeFromArr, removeInt);
        Console.WriteLine("{0}", removeIntRes);

        //Valid Parenthesis
        string parenthesis = "()[]{}";
        var validParnthesis = ProblemAndSolutionOne.IsValid(parenthesis);
        Console.WriteLine("{0}", validParnthesis);

        //LongestCommonPrefix
        string[] strs = { "flower", "flow", "flight" };
        //string[] strs = {"dog", "racecar", "car"};
        var commonPrefix = ProblemAndSolutionOne.LongestCommonPrefix(strs);
        Console.WriteLine("{0}", commonPrefix);

        //IntToRoman
        int nos = 1994;
        var noFromRoman = ProblemAndSolutionOne.IntToRoman(nos);
        Console.WriteLine("{0}", noFromRoman);

        //RomanToInt
        string s = "MCMXCIV";
        //string s = "LVIII";
        var romanNo = ProblemAndSolutionOne.RomanToInt(s);
        Console.WriteLine("{0}", romanNo);


        //MergeTwoLists
        ListNode linkL1 = new ListNode(2);
        linkL1.next = new ListNode(4);
        linkL1.next.next = new ListNode(3);

        ListNode linkL2 = new ListNode(5);
        linkL2.next = new ListNode(6);
        linkL2.next.next = new ListNode(4);

        var mergeTwoLists = ProblemAndSolutionOne.MergeTwoLists(linkL1, linkL2);
        //Console.WriteLine("[{0}]", string.Join(',', linkListTest));
        while (mergeTwoLists != null)
        {
            Console.Write("{0}\t", mergeTwoLists.val);
            mergeTwoLists = mergeTwoLists.next;
        }
        Console.WriteLine("");
        //Add Two numbers
        //[2,4,9]
        //[5,6,4,9]
        //result [7,0,4,0,1]
        // 1 -> 2 -> 3 -> 4 -> 5
        //ListNode l1 = new ListNode(2);
        //l1.next = new ListNode(4);
        //l1.next.next = new ListNode(3);
        //head.next.next.next = new ListNode(4);
        //head.next.next.next.next = new ListNode(5);

        LinkList l1 = new LinkList();
        LinkList l2 = new LinkList();
        l1.AddLast(2);
        l1.AddLast(4);
        l1.AddLast(3);

        l2.AddLast(5);
        l2.AddLast(6);
        l2.AddLast(4);

        l1.ReverseList();
        l2.ReverseList();

        LinkList resultList = new LinkList();
        ListNode temp1 = l1.Head;
        ListNode temp2 = l2.Head;

        int num1 = 0, num2 = 0, nCarry = 0;
        while (temp1 != null || temp2 != null)
        {
            num1 = num2 = 0;
            if (temp1 != null)
            {
                num1 = temp1.val;
            }
            if (temp2 != null)
            {
                num2 = temp2.val;
            }
            int nSum = num1 + num2 + nCarry;
            nCarry = nSum / 10;
            int finalSum = nSum % 10;
            resultList.AddBegin(finalSum);
            temp1 = temp1.next;
            temp2 = temp2.next;
        }

        temp1 = resultList.Head;
        while (temp1 != null)
        {
            //Console.WriteLine("{0}\t",temp1.val);
            temp1 = temp1.next;
        }

        ListNode ll1 = new ListNode(2);
        ll1.next = new ListNode(4);
        ll1.next.next = new ListNode(3);

        ListNode ll2 = new ListNode(5);
        ll2.next = new ListNode(6);
        ll2.next.next = new ListNode(4);

        var linkListTest = ProblemAndSolutionOne.AddTwoNumbers(ll1, ll2);
        //Console.WriteLine("[{0}]", string.Join(',', linkListTest));
        while (linkListTest != null)
        {
            Console.Write("{0}\t", linkListTest.val);
            linkListTest = linkListTest.next;
        }


        Console.WriteLine("");
        //var linkListTest = ProblemAndSolutionOne.AddTwoNumbers(l1, l2);
        //Console.WriteLine("[{0}]", string.Join(',', linkListTest));
        //Two Sum
        //int[] intArr1 = { 2, 7, 6, 12 };
        //int targetTotal = 9;
        //int[] intArr1 = { 3,2,4 };
        //int targetTotal = 6;
        int[] intArr1 = { 3, 3 };
        int targetTotal = 6;
        var twoSumArr = ProblemAndSolutionOne.TwoSum(intArr1, targetTotal);
        Console.WriteLine("[{0}]", string.Join(',', twoSumArr));

        //KnapSack problem
        var items = ProblemAndSolutionOne.sample_item();
        int capacity = 50;
        var knapsackTest = ProblemAndSolutionOne.knapsackTest(items, capacity);
        Console.WriteLine("knapsack Result = {0}", knapsackTest);

        //Breadth-First Search
        Node node = ProblemAndSolutionOne.sample_tree();
        //ProblemAndSolutionOne.bfs_traversal(node);
        ProblemAndSolutionOne.bfs_traversal_second(node);
        //Console.WriteLine("Binary Search Result = {0}", bfsSearchTest);

        //Binary Search
        int[] aarr = { 8, 10, 22, 27, 37, 44, 49, 55, 69 }; // given array  
        int val = 37; // value to be searched  
        int n = aarr.Length; // size of array 
        var binarySearchTest = ProblemAndSolutionOne.binarySearch(aarr, 0, n, val);
        Console.WriteLine("Binary Search Result = {0}", binarySearchTest);

        string revStr = "uhsnamiH";
        var revStrTest = ProblemAndSolutionOne.reverseStr(revStr);
        Console.WriteLine("[{0}]", string.Join(',', revStrTest));

        //int array sorted by ascenting order
        int[] intArr = { 3, 4, 2, 1, 6, 5, 9 };
        var ascOrderArr = ProblemAndSolutionOne.ascOrderArr(intArr);
        Console.WriteLine("[{0}]", string.Join(',', ascOrderArr));

        // Morgan and a String
        //string a = "JACK";
        //string b = "DANIEL";
        //string a = "ABACABA";
        //string b = "ABACABA";
        string a = "MZBMWEYYDIADTLCOUEGMDBYFWURPWBPUVHIFNUAPWYNDMHTQVKGKBHTYTSZOTWFLEGSJZZSZFWTZFPNSCGUEMWRCZQXYCIVDQNKYPNXNNPMUDUHZNOAQUUDHAVRNCWFWUJPCMIGGJMCMKKBNJFEODXKGJGWXTRXINGIQQUHUWQHDSWXXRXUZZFHKPLWUNFAGPPCOILDAGKTGDARVEUSJUQFISTULGBGLWMFGZRNYXRYETWZHLNFEWCZMNOOZLQATUGMDJWGZCFABBKOXYJXKATJMPPRSWKDKOBDAGWDWXSUFEESRVNCBSZCEPIGPBZUZOOOTORZFSKCWBQORVWDRMKLFDCZATFARQDKELALXZXILLKFDVPFPXABQLNGDSCRENTZAMZTVVCVRTCMBQLIZIJDWTUYFRXOLSYSXLFEBPOLCMQSPPMRFKYUNYDTMWBEXSNGXHWVROANDFQJAMZKPTTSLILDLRKJOYRPXUGICEAHGIAKEVSJOADMKFNKSWRAWKJXWCMCCIABZBRSKZAZJQTLKIQYDPTPKCSDGCQJSHZNDPVANNRYWFRNRGHLJJQRXPXNLKCWDPDKSWVTXGANWWYOOSXTNEXEEZJXOUYFJHNWPQFXEXZXFOLPCFBLPNCETYHTRWXKBOSCCSKXBUVCROSAVNPXZOEOYYGHBBQKFLSUTPWMHQWKVIRMLFCPIDLQYIKZMNTTAIFCBOPNWEZESOMKXHAIAFMVKBJAISYRBTULTPNXBCJMORNQUMATSERHIEQGGRIVOUWFNBNGHDFALLCPRVNGIKCAMVPRZAEAPQMILWKBKGOGOCNIAAISORFQXZJZTVCGVZLCEDWNEZBWXMPOBMRVXASKWVVWQUUDRNWHMMZHEQXIWHFUXAVLWFTGYXXHPYGSPVWDNVMGNWNPKDRNZNZVRKMJJMWISYRDKODOAFWSJFUVMEEWPDWPIYMWBHOXEBJIBXPHIEFGTSAWCDIVTLTRSHJQNKKMDTJGSCNOZMOJNHIGIPPJEMZZZBCVOYPLXENFFMFDZDIOJUODGBULVIVHTBHAYEEEBIACTYAOVQBIVUDYDGXWSGMHLRACAAYIPSOJLEQHPYGSHCVXWWLNEBLFMNQGDDQPCJXZFTWRLGPTRKBKRLWGSNLCAUDZDUJBBQLFZIKGXOHVHTUVCJMMWVHKXCGYEKJKKLCJQONEPPYDPSPIWQBKPSUNEDQIXLSIFCOKFRCVRSZCVDYFWUHTZPTBBNXBHQJOMXRBHJQXVDASERFFCVKECQYLQPRAWYQUEVHVUZCVFMBEWPXICSKPMZSBSUSMADDQKWGFIRLZZBCZEGHMUHXNXEJRSPCVQEJWOWQSFHOVHCTWNHUUVEPRRIYFWSTSJDECYYFJBJSDLEGQLKLXIYRWVLPPOMDFDTVTKWOKIWWPEJXIBDKNPONPSXRYTOQGJRTJPATMDLHMQEGVJHVLEHSYKRLVVSSMAMBZUSXUSZYYBDRDVZDBEXSGLYOKVMYKIFWGFNCSACJLKATHFMNLCTSQEJFOXYVMTOTTLHRLYPBZISUCLLQGAAITMXPMFINSOWJAAWSNMLUIZVPJBEWQCIPCQWVSQFBEUTDCSDRVIOZOBDYTWSIMSEETQCKLNKXTAWOXIYSVZRAKQEISPNDDXTNFQALSWXSMKSFOOIWXYNAMDJXNSMKIEWKWDPZJPKIBCBBMZBIWPMJCZCEHTCZQJZLKGYVSZPUUVETDFLUUHXPEOPUXMDYLAYSTTENJMCEDCUMOEEICJTXKKVXCXJOWRCVLTTSQHWKBBMIGTQLOVJGVIYZGCQJVPVOTWUCSETIDICYHTCMAJPHXYYOOEOVUXVUPLOKLPBOVQDWDYPBXGAJUQWADGEEDJKGURHSXDVYLMYFJQLWZLDROUYLQOBSGEMWDOIBQVCYEDFVQOPFHKQMHUSXQACOOGJXCOXBFZLWCXFVQAAVFEGKCIRQQGDYHLJMAQZQIFUAOUBUKYPAVEBVDUJGSULAHKPRFPNZQAQGVFDXWTQFLCEILPMSZIZFWBONXPLCYQITTPKPBCFSESGFBIQNIPOLEFRELPHJTHQRZSPHBNUMGRIFMWIZTFUHQIBGAXDVYSYVGXLSPMINYKBYUMEPUBRXUOAVYOVDBIELZDOBGQCJZNJBEXALKGHYWIOXZBVXZFCSHCOZMEFWCRVYIBJDFQVQMHXDPCCJODLGVKPLRFDEDPZOPRFEECHWSZHVCDOOEJLCHCWCEKTFRDMOWHSUEAVBRAWMIHZSNFHRAFBQEAWDIXZNPPFWIEAIVTMPQZQTSVNVWJMGVHUESSSAXGMOYWDGVWIOUZUQDEBIJCQYCFTAFTUWTGXAVEMCIUQMXENPRPMYZREXSHNVTESSTWHYTMATXBUZXPSTPYGFXPHPFCKJDBFBXIMEESWYNDFHOMCNWJTFRUVZWBHLZBVEBYEUCEPGCDPMGHCIBFXGRVNACXWLOPXSVZCLWYMWDMOLJTAGUWUVHXIFDJQSHLQAUEGLQRBXUWPOZFVEGDPVNWMEDXBMXAGIMXMXGJLNNFKWBRQSHXFCANWPOFLQEJAFDKTNLPGVLEXCYGLRZBKHCMXVUOBYXCXZXQMLSWVLMBVCSDTEFCQTMLILWZTBSCFHJTCYTONMLIIVRKBBLVNMHIPRGERYRPJPJYKCHNEYFYMIEFYMAJRNWJSLYTBXMDUWTFZAFKXYFMCNLJSEBZLEYGEGUUJMKYYLFMMVVILJWGCYHRDLDKZFZGTVMOWLBEQTJSODVHBUUMEXPPCDXQHCEQLDFAVGQLVITUZZNGJEOTBKJZCRTGGLUIAMNCORBKIWDOZITQGQIPHVWUIJWHSMGOGXOMLUQURCWOGGHHJJCEKGGLLAMQGXHCFCMRAKGROJGXIZWXASCASINZXCDXEWCULOFITYLHXHZXMJDLISUPDYLSHAHCIPZOPTULLYISXSCZJQAWAGNNGCGGIWKHNARJISVCDPZGGTLLUDVCSJXEUBFGYJDIMTPFTGYTKFNTYLNFLBFUTSYOVXMLIGOAIQZLXWFRSLJUCDXSSAMGCIFDLJASHCJJWHLKQNIPXZJGLPTEDZXMTHVZGRUHHCKUFDECAKRRZOQFQCDUZHJSDASKQGLQLNNBKUUYTQTHFCJRAAWTBCCURPZPUMCSMQHEBHQRFIGAMBLZXYCVEVLUZCUQXVRJGEKYAOFVRVCOHLDAVKJIYKHCCMNJPDHKKIMPSMVCYQXLGWLBHLDKJLZWTHKFNIZEBVLGOZRNWWVXDCKGNCKQTKQIDHOOCIWRPKXESLDTGXTAURGLBGMPYQLPZBNSBZHANBIYPUZIQURWRBRBXMHBRDPDRERBOBAJULDLWRPKRTFBLSPNKXYITIOHLPGJLCKTLAQSALNOIPHBTUYRRGHSEZNKMZUKAIIHATZTTIYLACTADTNINWCSUFBYNJKXAAJNAGFEVSCFUHOAJUQMISGBBSXQBYLMRASZACPLIUGLQYUZBNIZXXJXNNTSCKJZJZJMMYFMVXJAOPVEFHWHBYOAPKQEDYDDTRPBLPORURSKNPBTAMZKKZRRDDCMRAYGLNJUIKQYNJAUCAQEKHCWXDQPDOHYCVAEXJYULGVWTOVQGSFIVKVUNQDEKHNGXJYYCSPVZULHKYWGQJGAQCLPSXNSERDNRJXROZMXTJTVOSSYQPVOTKHMBQAXIQXUXZLZTKSOHUJRTAIMPDESFQJBJIFGYBEBNUIICFJTEQFVSYRWWJZISSAIMGCUSLEIACQXJIPDTILJQRBLDLIRSIEWJPLNAIDVVIXJQTQJDOZLDBBEEMVMVEQLHJZTCOUOSTCGROMEKRINQBGVGLJHVEAONQKRTJJTLGBKRNYOIXIRSLFSZFQIVGKAFLGKCTVBVKSIPWOMQXLYQXHLBCEUHBJBFNHOFCGPGWDSEFFYCTHMLPCQEJGSKWJKBKBBMIFNURNWYHEVSOQZMTVZGFIQAJFRGYUZXNRTXECTCNLYOISBGLPDBJBSLXLPOYMRCXMDTQHCNLVTQDWFTUZGBDXSYSCWBRGUOSTBELNVTAQDMKMIHMOXQTQLXVLSSSISVQVVZOTOYQRYUYQWOKNNQCQGGYSRQPKRCCVYHXSJMHOQOYOCWCRIPLARJOYIQRMMPMUEQBSBLJDDWRUMAUCZFZIODPUDHEEXALBWPIYPMDJLMWTGDRZHPXNEOFHQZJDMURGVMRWDOTUWYKNLRBVUVTNHIOUVQITGYFGFIEONBAAPYHWPCRMEHXCPKIJZFIAYFVOXKPASYIWXMRAHUWLAOOVREJHPBIIQMDPTEFNNGFZTQHHIFMTHLXKQBHISDXBGOTYSPNVUSLDLFCNOGNDBCJXQDUSSOEGPWPRFUSSJQHKHBHPHTJKYWSEBAAVJAUPVDBXFITSYOJEVYCPXWYXFKZDESBNOACIXWTRHQHFIMUKKDINHWYXNJKMOPBHOPLFMPLQJYFIAZKXXDMZBNDUOAXJDAEVIBEQACBDXWRGSFVPLKHFPNLPFLZNDTLUWRIGJJTTHZHPOWRYLZZYVNATBAWWXBYDUUSBDHBGGAWQVLRBMPGKNZVLKEEAVEKLVQUTZZDRQONOWWVWJFXXLTXMXKKPZKYFZSVYVKVNYCVPNPQBRIBPEMMAYFPNIWAZHBJEZMENVESSYPPASIFGSSFWVEUXASVKMPXZVZOOPTVOZCYQPXANFTSVGLUXXMWTERTADXMAMTXRDQNPLOAGMMGETHVBNEXECQIDNZPSZHLHPSOEMJFRDPFAWNFHYQUWIWNUQZTLHKLUBMJMQIMOYUMBUPRIGZZXVKJJOXHYUSUKLAIYMPOPZYVEWMVQMSOISXZUHSQAZGGGNMRUXDKVGPUCMTZOSJLRPDWAEKOXTRAWMHIJIZUQRLNKIEYLAIIYMTDFTXJUUCJIPOZZHGBIZWMNCRCABVMQWAFVMUXYYBVCIURGYAPTMPVLCNYUHAYTABVKSPWISDSDSPXYSOPDEMQDGQAXUOOOMPKYSOKVZZHDPMVNURNAULFUTCUKWGTXNQXMUKBXNLIDVYSEWBWMSNSRFPXXFTMJUEDKSDMNBKLSRNJPWVPQWMXXTFFGTBDBJIFNRVWZTBDJRBAZXOTGFQVYQPGRDOJJGJVQIWLDVJINOEEBSCJCISYVUTVHVMIYCOYSZFEXXAFMKAXSXWKTFCFAILJABWUNYLERKSNHSAQNHOVLTHJVSUMBZQSJHRLLOVOYUBXMXBYUNVAADRVBEJOORBYHWUNRHNIXRHWODLXNGPQURFPIQDFTESWNRNYFNRLLTCTMJVSJXPFQSGPZEQQTREWWSCEICEANFVODTIOKDWTZOQOBOIIOXGOMODFASZWZGUZZYQITDDCINEMYPCBFELHMHYPBTBWMCHQHYGFTVAOFPXWMPMFBCFNCLQEXJGVZPQBXCQOSKJDXWHIMEUWXOPZAFASCSXAWAROBLPMAMKLRWLZNPLGSPUZVNUBPUDIBPTDSLAAGXAAACQRSFVHCLAEDSMLKJAQSOQGFPOVIGXFVHLTPWPTOJSARDOZOGRLTULBERIYWIREEBJDDKDHPYLEYPYLEVVGLKCKUBMYGXZQMEEYEHJEHKNBKPRSVDGJOIZZGJSZEBTAQQGZWYFGDCBKDGXZURJPOAHRHDPQEXZSRPGVDUTABOGKWKUEHFZWHVAMSNTZUVCRQZPLXHYKIAOAPJZKZNMLSNEZSSKDLOSIYFAWAZNBUWENOVCSFKFUHNTGLVESXSRRNZKBHZKHZMVKJEVSRBDICLCKMSGPGNGYCKZVGYSVWCGWAYJOKQACTFXTIVFBDWPRUFIVTGGZHBPVLXFKISDNEOGDSEENJLEWROBJHPPPJCZYXEAIQANAZTKSNPFWYHDJVIPGWZZNMNNXWRAIIEICSCDHRYZVRHTOPRRATXUFCITHOKIOGUDGGZPVJCTBAHNZDWTOKIATSRIQZWEDRRFZBRKGVYNBBFOMOIAWWMMJIQVHDLNSVWNWBKTEHYKEVHACVDFLMNKRLJMIJVFXDVDYDMVKJSBPMCGMNFTSEUMHBDIOHZCJVPAYXQWDPYCHQCTUDLKEDTBJDUQBZWXVOXJLAJSTAOQNRRRPXCNDMWHLWDYGNNORDXMUJNZLKEAMDXANOKVBVPLRWXZIJPJKULODEULUEPKSLYIUZYWPYYFOCICAZYEWQYULJLFMTHLIEOLXUYPKQPEMFJJPSWULKNGYTFFIXVOIYUUSYBDMYGPUGZHUERHLFELEMNNAVEFSUQIKNYEDQTXYEKPWPDPCUUIMOSYTASPBMINXPVBCBQOLOSVBRPPGPYVIXLSXHQDRPHMJPIHERRWHDWOSAPJFTERGJSZLZWCIHWCUEGFCPSAQJNNFFMVVEUPTMNEFBHOHJBCAOCDWJYAYLNVZECIUCLQUQEDNWKYFYMGRFMZXQPEJCIXXPPQGVUAWUTGRMEZJKTEOFJBNRVZZKVJTACFXJJOKISAVSGRSLRYXFQGRMDSQWPTAJBQZVETHULJBDATXGHFZQRW";
        string b = "FGAKWMOAWLZQJYPMHLLBBUUHBPRIQSNIBYWLGJLXOWYZAGRFNQAFVCQWKTKCJWEJEVZBNXHSFMWOJSHCDYPNVBUHHUZQMGOVMVGWIIZATOXGBLYUDIPAHFBKEWMUNEOQHJMBPDTWNZNBLWVTJRNIWLBYBLHPPNDSPOJROUFFAZPOXTQDFPJUHITVIJROHAVPQATOFXWMKSVJCVHDECXWWMOSQICZJPKFAFQLBOXOSNJGZGDRAEHZDLTTHEMEUSXHIIIMRDRUGABNXWSYGSKTKCSLHJEBFEXUCSYVLWRPTEBKJHEFSVFRMCQQDLANBETRGZWYLIZMRYSTVPGRKHLICFADCOGTNIGDRXASLQUOLBTOMEFRTOCGSYYXMMSOESSJMKVHSKPLOEETLFVCJLILCEMZWTVJILGDVBVAFAEQQOJYPXJDYXDZXBTKCCESYMPAXXHZCAQJDOIXJIIVINPIDPFJHVAVBWPCKQNCJWYGBBDWBQJVDEHKEVSNTANOWLERSAPPRUOKYWNEGNCMJVJXCSALRMIUSZJMKAPBWDVDNJXNXRNLMIRLMEHSAYUHJPAJKUXSYRIRKPMGZCYUPOIGWSDQSUXMAIXWSQGVLRJZFCQRPHSBGRSFNEAIJELHYRUMKQPKQKLSACNHPZNPXZSFGMCOUBKPCWZMKMAXJYPVSWRIGSVQGOGOQCIVAZSINDEHAOZDDWXTTFFSHOVPVPOLDLONLKEGGVXCYQKABPWNRZEJFDOPDHXKOQSPEVRRJEOCHBDFQBVCOYVFFVZAUUFRROHJTXNJZPMKDKJBFQFLIVIGIWZTGBYBUGIFDYHOJTJKOAQIEHKJMATGYHGKJUMWVALSQMCOIIJVWCHNENIKRLIZWKHKTDXTQVXIBCTBNBXFUDIVICNLJLNZPGHKVJCOSVFNRYIPIIYLOTXANMKCLJVYYCMRTSCNDZIVGHXAIGWXSKRKSQJOKVNCECTSFXPGYORKUFSAACIQGNCVXTGHWTPBNFSKRMPZCYMXUGWJDILCORKRZPUEWAHXYLCGNZKSUSRAUPTYMACGTSTKDXWYGKDRGGMQKOMLRWRROQFNZPVWOCUAGGXCVBFLAUQXQBWTFYHPEYFDPYDBFANCNKGTYOMYHDODVBIQNEQFWSVYFRPIJYGJDUHWAGGCWZIDPHKRWYJCQGZPSRLCJUYBMGAORPPYFFUNUONATQSEYSOUBMIAFJBZXUIWSZUOVQEWCOLEJFLIVCKBBWDJGMZVFKXZXFDCXBAYMMNTIELKJNZKODDCPFEPDQHGYRAWGYMAMLJWNBIEAWIUFAEPOCJMCSOYNMIUPLAEKAXEXIYJFHHGXEQPXSVIEVROOOPKWNVXQAZPXLDLYEQWDUIQURNWSMXXARZOAMPOQOXCMQGAMIHMSRJNRLNIJTNZXCDYCZMYFRUWSFKVXVLJUPORLHZEQQZRLYDQLXTGJMXDSTCRABJCOPYBQYBAALILYZHYSADROQIJFHYVGZUFDLRZGECMEQTGKFGIFPYIEHMCGRPOPMOZMAECXFPKWZEUALGFDMDEXMKSIPYMEGERUXGTGANELJAMWVTXFQFCEHNCNHXAYVDRKWPPXISCAYKVMKYJKJJGZIDBATJUJGDCSOQNLXGXXDEYEWHVTNCVPUSJINBRRJCWFXCAFBXPYTBEYPCOSWMPDCBDCMJSFZYOOHDZYUDJOUKIOWFCMHPLICCYHIIGRNJMXYAFNXNFZVNBNSXBKAMPSWFMOOFLQWWDNSAJUZISGRZOZDGNHHUAIBGYCTPYQHCXCHHYGIHQAERMSPSGOMQKYLTMRFGQBDHILOYXFITYHEWGMVCAKCXUNUXOGDVURUMQOGWLJLFHYSYJVVEFPKBYIBZEQFJHZYMHDKDZUEQDHNYVQTUNONRXJNFBRUKWLFITFMOVPQNROHZNPYFCOZUGJYBLUVNIQUKMSWCWSRIWFQNHOTBAYAEQVYPHRKWUTQICJOWQMQNEITNCVUAZZNJOJVLTIJKFXGMUUXQAYPFTSRHSIFDBPPEVHQEDZPWOMZRSDEJWFSUUXEWAUMEYNNLQRKNKOTNCFKNVZSGBKEECUVNQPEFKGBIDLRSKWXIOCWGRAIDGDLEDUTXCLALKBNJNWMGSBOTNPGRVZQRGJKWPKADHCSCCXYCUKRESWGWZYJORWCBOKBMKPFTUCREJBRLPNQHMCCQJNYVEGKVPEATDZWCWABGKZEKKDYFGUBJDFDJNILUMMWXGVHHCFGRZINRODTIDTVLUOBAWQMXEAMUMKSCVLHMIVFUBJCMBLWKOXSKIRGQGNILLTZTIEAIPFRRSHTQLHXXIBAQMQHMBKAIMRKZVGEWNJPEVFQGYWZPPBIEIGZKKMPPLSYWCOFXBLCYJVESUHOVQVUYGOLNPQFPYRWYIUBIWQJDJHVJNTTZFNJIMRYVPYHOFLQTFRRTLDUJWPINXMJMCMWZMDLUUBVWSPACMHCWANDVPQYIQTOZIPDDJLATRPRDNYGMBAYNLFZMBMTRYTSQSXSUEJLGOOQEYUCQVJFSMHXMHXBCBDQSKZNXNNPHSOQJFMAQKLCMCKFGIESZPIRGOTZGVLHINLOGMTFNRQNXOBYLZDDFYFPYTCDEZITDUQHOZQXQXXTXGPZKKBXMKUHDOMJNRFTOJTRFYUPNVUOJDBUYCZOAHWVUUVVZAPUNXUYPBQQXRYAHDFHFRJSXYUKJFMRUWPJAJJCVJBKXPTGQCYXDCVAAJMDHKBAAXQVZIGYBWNIUFUCUCBZTNISVHQSZVKTILNAGLUPTRWDGTCDZJJXCNWESQXFFBXYUQMQVYDZSRUHXEVQYMJURMJNILNRKEEPDSYYSVBAEKSOZXFNZXEWJRVCBOXLJNXJDXGFHTGRDXOHNJTIYNSPKWGTNXSXJRIJYTXLCASQPDLJZLNXVPSBJQEKRUNUEHMHNGYUMGJHBOEOBQNLIFESKIVABBAEPUTXUURWPOWHFUSACEJXOMOSQBOMLEUGDHZLVTZVJKZPFZYCZIVPIOARKAXAWRPXYZOSGLXXLPWNWNLZFJDLDRFFUDMYWWPJTLKXMOIRWVOLEKXPMYHDYJAEQWKNFPAPUEGIRCDOWKUSEYBNBRCWSCMLUGZFKOVXYSYPZEKEEDCEMNKIHRYLIZMAKZWCDHQDXFKRVSQFHCLIUBNUWCJKDGPOYNPPAGPZHMMOVFURADZEMPDWJFVVTGMSALSWWBVJAHWERCTOEZQYYZOSXHIJGKZKSPPPVVLJVEDHURQYXRLHTEZGPHNBPUHGKMRCLIVKHNZTOXSEJNOEPWPAJUQRWZXNOWQXQPJBXZSYBTYAFRQTLECKZUXDLWOUWIJCGHHGNSOWIJQPHEMOJMZAIEORVNBNSWIUUYYTMUTIVRDUPCGUVSGNGMQWWSKXGLDLVDRMMAQHCZCTLDSRYAYGNNDFGJGNUALNZRULIRVGRHHPSOZMSTVDJCSMAACHWIGJSCNAPSUMXPZLLLVJJFOAMEMXUUTILACVKECCFEZYWBFTNBWYJTYBGRJTQCKYTLHDZZUWQKCGESMFUCYQPJLQXSJRJSNFUWBDCDQSAJDIMLRCVTJCXOETTGXXJJBCNWUNUUYERUOTKWXKXCTOVEUNECFRCWVYTIYTUIWSVWQWPIJISKVOQGYEYORJHDSKBCATYUPYQPBXPVTLTUDZMIVFLMFCERJOPFQFWTJCYAZCGRMFDLVLBAXDNNBXTAOSQRGJERNPPFRMAXZJQCPQMQHMSIRUQEUXXVEVDTKBGHFVPNIPVGLDDRRZQWOHCPYAKJCXKBOPXMXJKIAWLYIBCDHBXEUNRSVHWSVEYYWAWNFPJKPBCPSSADRKYQVSJRQBYEBEBCBAAEJCJNOYVYRCJUNQYAGAZPGLNZYRZWMOUNBIIVRLFALQDKMIVHIXJQODZCMCGUQQYXTNOUARYQCMAEIDIQVRDUELOHDQBAGTNMIWEUGTLGUGDBGXRIKEWSVURSYBMOTAOOCREFBNBLEVNTPELPJKUOYHWQJJRIVBQWZVUZWOUBMQBOMBBGQBFXHWHIYBFKVURXXGKONDDFORJOJTUTTNSDRLICJRQSSAAPOWJZUIFXQMSVXQJNNOXIJPWCMHGCBIGWDADEARLEAYZOCHOCEGGMOPMXQSZWGEVPGJISNXEPRDYQQDFFIOAGLKBVXVMQOBEAXNFVERARXQLPTSVRNETGHETGLSKMDXUVOOCGPXLDYKTWUJXBBUVLNFBDCFCXDVGXVBVLXCQKCODATAEUHVSKLCGCWHSJWWGAZCZVZNYZRVHXETFZZAWPKYIGZATNXIAVEVWFJUONOQDSKGSNDFXRPDSNGZOFADTEIZSBIBRRVUBFANKRBKPXNJXQPIJMKSNJRTYFLTREYENPGSAITRJDLEYPOTIMVWOXNVOJZXBBNTNUMOMGZLIJHAFVZRODTNWETXETDNXQQRNNNGQITRTFQTUVMHUDFEUQPWCTKVQAUTEAZSJUCFGPLKPGEZVDHWVUZKBHBIDBTNSHGWPFSLNWJGPBPTAQYLIBHZFYWZUSZPACXUKBZWOPDRKTPYWOIRJWFEKXONWBYKSTQUKZAJLUJJULEQORUFTAFGNKISKXKTSASSJRRWPOCEGOWQKSBSZLSVSYGALCPESNTLDJGRAKLQZNGIQYNIFOWBGCTQVAZPKUULWUZYIMDLSGKONXBYYTNTZKXFTIJJRWCRSEKWATROTURZPNOSLDLWPBOGGNJCWTFOPDHQGLLWXRYDXERNSFECYJIXGWVETICATGAIJQIZLKGVHLHWSGLHEGZIYUOEQDOKCGBQFVBRNHHSBEPDYKKYYGEUTUIFLJAZBCNXISFCODIQOJDENGXJQFLODZVNEENRGLAVZYNYHSXRGDIQPNUSNCPYDZJQKTYELPGMSBKLVMNLPGXCIENKRBJUWCMLLBKPRLUFJLJOKYNPPXBKYISXMMANLXUYEIDFZVEFWWCDKRPIIUTRWMINFZXGETXTTSIGFKGOFEKPIUWYZFLPKLBIMTOFJPXQKDQYAOIWLWMJAKZVHICDMYHCXGERYPPFGVHEPIMGRQOLQYIBJPHSJKMDKAQBKYWTBQEHRMYBEVNQUTDLYQPOGEMUUDZXBHJLBGVDNZUNUBUEPBCSJBPCYDEHBRGJPPIQEBGXHDTQXWIZICHYTSCEWAOUDJZEVUODGDGQFDZVRBOXOPVFDBOYSKOLRVDFOIRKQPIWOWGYPYBCHBMWTBEAOLSRXQCOXWNTBYIMAJFPAUYMWJWIBOTKZIUTTJQCNHUDHYLQBXRBXKVMUDTHUTQQENFNCSHTAQSWMQUCJVUZCETVNQQJSSEBSLRICSVMWQAKEZGIRYRHLXPEUGVSBIPCSMYMHULYKRIYHDMASFCJUIGRWJCHMJSLMPYNEWNZPPHMUDZCBXZDEXJUHKTDTCOIBZVEVSMWAXAKRTDFOIVKVOOOYPYEMIIDADQUQEPXWQKESDNAKXKBZRCJKGVWWXTQXVFPXCWITLJYEHLDGSJYTMEKIMKKNDJVNZQTJYKIYMKMDZPWAKXDTKZCQCATLEVPPGFHYYKGMIPUODJRNFJZHCMJDBZVHYWPRBWDCFXIFFPZBJBMBYIJKQNOSSLQBFVVICXVOEUZRURAETGLTHGOURZHFPNUBZVBLFZMMBGEPJJYSHCHTHULXARZHIZEIOEPWBIZHZKBDLUYTBVWVQIPIZQCWCAJKUFNQHMCRMMXZBLJPLVPXJGEXDFZLLNNBUGBMCTHSPXENWOVYWDFCHIDWCSTLBOCFZZYOCNMGAAUJTRLQSNIFLVEHWYIPPBXHVUIFUJIFKWLTVJBKGQPOOPTXEMXKRXOIHBOKYPCIZINRXTBRAXNMHKCSSHGUUATPPFHDHNWPZUKJYBKKVRMMPUEEHKJYRCRKPKHTBFQPYVRCFQALHOIKWFSQFSTYFPRAAHXHJXVSSCNGGGKGNHWHEPGUYAVZCFDKQBCMGROIDXRZYYNHWCDIUSRIQSAOWCZWUUYELCXEPXLWDCKNMDXAUTBDNRAHITQISZNXNISYOORKEPOPRZKLKGKHESPPLQSSAIMTLLTGAFHVLCCIZTDIDXPWHDGHOSCIGPPTAURARUEIHXOOOTZELVQBHVOQIOZHSTFXPWBFMGLKICKRGWOLHOAKATSSJLITQZJFHDFZLMDADKYPRFJSITGVQAIOFZWNKPRYCKXSJOZUINKHUFNWHJCYANIRDGWLFWUJGZCFGRLNKVYFOPQZTSUQSHDTKDGBRRKXWQPGLIPCAASJHKLYPYUURVGZBFAGBNQJWKSDMGDPFKDGQYGSEMVFITDEILCYDJNHUPZVEASVKJXGAMXNTQFZNQKMSOAREINWJEIKYORROZGFZHOYHMKUPVGURWSLCQSZRMOAORLUILDOYUBSXOYQZHCBRGIFOQRGXBYCQOOQDZMLTUWIQGFULDUPXAVNNJTRELAQIKMVGRPYSHCSTAHTZDBRVCHPTOADVZUAIKCSZEGAROQJNJHMJCUMBXGSZKTQFRUOSTVEVHHHECIOMZZKFFNHMLKYETBKVNVDOIMAKKOLLYUNRCNQUDGAZMEJGOAHKJAFILHXVQYSSVATIGCJZXIBTIRITDILDTFGGBYZOBBMXTWDAJAWQDYWNPPFLKKMTXZJVXOPQVLIWDWHZEPCUIWELHBUOTLKVESEXNWKYTONFRPQCXZZQZDVSMBSJCXXEUGAVEKOZFJLOLRTQGWZQXSFGRNVRGFRQPIXHSSKBPZGHNDESVWPTPVVKASFALZSETOPERVPWZMKGPCEXQNVTNOULPRWNOWMSORSCECVVVRJFWUMCJQYROUNQSGDRUXTTVTMRKIVTXAUHOSOKDIAHSYRFTZSGVGYVEQWKZHQSTBGYWRVMSGFCFYUXPPHVMYYDZPOHGDICOXBTJNSBYHOIDNKRIALOWVLVMJPXCFEYGQZPHMBCJKUPOJSMMUQLYDIXBALUWEZVNFASJFXILBYLLWYIPSMOVDZOSUWOTCXERZCFUVXPRTZISESHJFCOSALYQGLPOTXVXAANPOCYPSIYAZSEJJOXIMNBVQUCFTUVDKSAXUTVJEUNODBIPSUMLAYMJNZLJUREFJGUTAQNROMYMIKEFRFROXCSXRKXPICTXGVLERNYTEFLNCIJHMLISLUNMAOSOMKSNMTTOFLZQLXDDZBFFTUMVXLTYDLONVAOCDEZWTPJOZMOWKQWCVFTEJHXUTNHJRGWSNBYTSGTIGOMKNGTMNAYTTZNCQDEWYZXWSOIESHPDAWCRZHBLLHLXLIXGIHZTEYFAXZICQWHABLKKHCLXHFOQBPCXWXPBVPAWLNFNATOFEKRBXSFGEJTCDQKZEUJUNFCUWEVYAJBJARUPRXSYKONESFURJQFGBXHTYMDQQICWECDLCSREWZIYNZUWNDNATNSWIGTQWMPLHTCQLCXSUNZWYACZGWVUEMAZDGDRCFPXNLVDZVAUUZVTXAHLRXDBZZGORUGJVMXEUGMYCUBKTUMWGRRWQILYUBVJIBGHOGAZNUBGQSEYSWUNVEWTCRHNIKGEGLIYJICZSEKYMTQZTHXQCEHSEZBHKUFQGMGROGEWPMRXLQWNINOGKYZXNIRLEGLHRKAFLJAKMKUYDGLAMGUXUCRWSYCUUOIVHYWYICDQUZGHGCYSDXMFADGFYWRJJSQMYCSDXPRNURIZKJVVRHPMCMODFSEJOEETZKKJFTDDMYSVXJXCTTLZSRQKRCUHLIUMYXZXMPKVFHTGTUIRIPAQWZKCEBKTAEUIJBTANRFTVKPNRNXCMFUMOTRNENQIWSVGJOBTBKHKATMITBNXTNSKLVILZIXLGMUFFLRQGFTANEXECPTWYGAHZICXTTRJWIYKLIRGHYQMLWYJDAVEXJHVZHRLPKWFHSQZPRGIRCVVSHSDMQYCWHJZANIHPDSVMWVJQTSLQELNWXTOQFVIVIRNIAKTVZBMVEWGHUACGVBGSHVKWGVRKEDNGMADOCZXKUPWSSPBCHWLGFMUEYTURFHBHZDUAYMBAWLRFJDFHMMOCROUSWMPYXFPXWWYXYKJUVOCTGKZZIIUNYTVXHKJRFDSQNTSJUDLMXJLKWIAQEOJUEFCCNPJYIXMZSMHQQJOTEODIATBBSRVBBVLTH";
        var morTest = ProblemAndSolutionOne.morganAndString(a, b);
        Console.WriteLine("[{0}]", morTest);



        //Bear and Steady Gene
        int n11 = 8;
        string gene = "GAAATAAA";
        var geneTest = ProblemAndSolutionOne.steadyGene(gene);
        Console.WriteLine("[{0}]", geneTest);

        //Common Child
        //string s11 = "ABCD";
        //string s12 = "ABDC";
        //string s11 = "HARRY";
        //string s12 = "SALLY";
        //string s11 = "AA";
        //string s12 = "BB";
        string s11 = "SHINCHAN";
        string s12 = "NOHARAAA";
        var countStr = ProblemAndSolutionOne.commonChild(s11, s12);
        Console.WriteLine("[{0}]", string.Join(',', countStr));

        //How to find unique integers from two arrays
        int[,,,] array1 = new int[2, 2, 2, 2] {
 {
 {{1, 2}, {3, 4}},
 {{5, 6}, {7, 8}}
 },
 {
 {{9, 10}, {11, 12}},
 {{13, 14}, {15, 16}}
 }
};
        int[,,,] array2 = new int[2, 2, 2, 2] {
 {
 {{5, 2}, {13, 14}},
 {{9, 6}, {20, 8}}
 },
 {
 {{3, 10}, {21, 4}},
 {{25, 16}, {7, 1}}
 }
};

        int[,,,] array3 = new int[1, 1, 1, 3] { { { { 1, 2, 3 } } } };
        int[,,,] array4 = new int[1, 1, 1, 3] { { { { 4, 5, 6 } } } };

        int[,,,] array5 = new int[2, 2, 2, 1] {
 {
 {{1}, {2}},
 {{3}, {4}}
 },
 {
 {{5}, {6}},
 {{7}, {8}}
 }
};
        int[,,,] array6 = new int[2, 2, 2, 1] {
 {
 {{1}, {2}},
 {{3}, {4}}
 },
 {
 {{5}, {6}},
 {{7}, {8}}
 }
};

        int[,,,] array7 = new int[0, 0, 0, 0];
        int[,,,] array8 = new int[0, 0, 0, 0];

        int[,,,] array9 = new int[2, 2, 1, 2] {
 {
 {{1, 2}},
 {{3, 4}}
 },
 {
 {{5, 6}},
 {{7, 8}}
 }
};
        int[,,,] array10 = new int[3, 2, 1, 2] {
 {
 {{5, 9}},
 {{3, 6}}
 },
 {
 {{7, 2}},
 {{8, 4}}
 },
 {
 {{10, 11}},
 {{1, 12}}
 }
};

        int[,,,] array11 = new int[1, 1, 1, 5] { { { { 1, 2, 3, 4, 5 } } } };
        int[,,,] array12 = new int[1, 1, 1, 6] { { { { 5, 4, 3, 2, 1, 0 } } } };

        int[,,,] array13 = new int[3, 3, 3, 3];
        int[,,,] array14 = new int[3, 3, 3, 3];
        //Initialize both arrays with some large data
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                for (int k = 0; k < 3; k++)
                    for (int l = 0; l < 3; l++)
                    {
                        array13[i, j, k, l] = i * j * k * l;
                        array14[i, j, k, l] = i * j * k * l;
                    }

        var testCase1 = ProblemAndSolutionOne.FindMatchingElements(array1, array2);
        Console.WriteLine("[{0}]", string.Join(',', testCase1));

        var testCase2 = ProblemAndSolutionOne.FindMatchingElements(array3, array4);
        Console.WriteLine("[{0}]", string.Join(',', testCase2));

        var testCase3 = ProblemAndSolutionOne.FindMatchingElements(array5, array6);
        Console.WriteLine("[{0}]", string.Join(',', testCase3));

        var testCase4 = ProblemAndSolutionOne.FindMatchingElements(array7, array8);
        Console.WriteLine("[{0}]", string.Join(',', testCase4));

        var testCase5 = ProblemAndSolutionOne.FindMatchingElements(array9, array10);
        Console.WriteLine("[{0}]", string.Join(',', testCase5));

        var testCase6 = ProblemAndSolutionOne.FindMatchingElements(array11, array12);
        Console.WriteLine("[{0}]", string.Join(',', testCase6));

        var testCase7 = ProblemAndSolutionOne.FindMatchingElements(array13, array14);
        Console.WriteLine("[{0}]", string.Join(',', testCase7));

        //append woth dollar
        //string ad1 = "gbcebabbfffcdgfeeaadecaeecabbabbgcafeabgecfeffcbafgdegdacefcadabbfdcgcebegbfgeeebfegfacdagbbgeagaaceefcaedceacceebdgebeecedcbdbeebecgcfcgdaaaegfbcbfffccffabbceafaagdedadbfcaedaffbaggebfedegfabefafefgdbafedbggabccaedabfgfgggbcfgeggdcdfeebaedaaccefgegbffaaggdcbbbfdbgaaffbbgcfafccdgcaabccbfbgbabegddagcgfbcdfdaccegbabfedbbdaddebddgegedgaabebfeeggddagaeececcafdgddceddcbdagaecceacgfabgccecgecgcefaafcaedfccdeeceffefadeffefggaeggbbfgcacgfaeefbfbccggcbcgeagcaacdcbegcdaacdgbebdaabddeagafbfagfebfefffcbcgefbcfeggafccabfagegccefe";
        string ad2 = "ckbjbibcbdhhkkfkgfkjbdebggcbhjkbeedbehdggegkjikhgibiieafdkiichaifbjfheijadadicacjbhehhgegghbkdkiedafjdddgekdeahgdjebjhkhbcjdfddggkdhjjgaajbihbkgggjcfaejkgdihkhdhdcaaddhddkdkcejehdaieaiciicaabkaahbjjbjegdbefkkkadjgaiegehedjdfebkhebacaaaafhgcfehfhkdkhgjffkgkfahikdkaagchkggjcheejecdcjbkdkhaeiiijadbc";
        Console.WriteLine("Append String =>" + ProblemAndSolutionOne.AppendWithDollar(ad2));

        //common char in two string then yes
        string cs1 = "hi";
        string cs2 = "world";
        Console.WriteLine("Common String =>" + ProblemAndSolutionOne.CommonSubstring(cs1, cs2));

        //check int palindrome
        var d = ProblemAndSolutionOne.IsIntPalindrome(16361);
        Console.WriteLine("m =>" + d);
        //check anagram and
        string strAnaPalin = "aaabbbb";
        Console.WriteLine("check palindrom =>" + ProblemAndSolutionOne.checkPalindrome(strAnaPalin));
        Console.WriteLine("palindrom =>" + ProblemAndSolutionOne.RearrageablePalindrom(strAnaPalin));
        Console.WriteLine("kkds=>" + ProblemAndSolutionOne.MakeAnagram(strAnaPalin));

        //delete anagrams
        string s3 = "absdjkvuahdakejfnfauhdsaavasdlkj";
        string s4 = "djfladfhiawasdkjvalskufhafablsdkashlahdfa";
        Console.WriteLine(ProblemAndSolutionOne.makingAnagrams(s3, s4));

        //anagrams
        string s1 = "aaabbb";
        string s2 = "ab";
        Console.WriteLine(ProblemAndSolutionOne.GetMinimumChangeNoToMakeAnagram(s2));

        //Palindrom index
        var palindromIndex = ProblemAndSolutionOne.PalindromeIndex("aaa");
        Console.WriteLine(palindromIndex);

        //How to revers a string
        var reverseStr = ProblemAndSolutionOne.ReverseString("ABCDEFGH");
        Console.WriteLine(reverseStr);

        var str = " Hello   Mojidul   Islam      ";
        Console.WriteLine(ProblemAndSolutionOne.RemoveSpaceFromStr(str));
        //remove duplicate value from an int array
        //https://leetcode.com/problems/remove-duplicates-from-sorted-array/
        //int[] nums = { 1, 1, 2 };
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        Console.WriteLine("Array is " + ProblemAndSolutionOne.RemoveDuplicates(nums));
        //var withoutDuplicateValues = ProblemAndSolutionOne.RemoveDuplicates2(nums);
        //Array.ForEach(withoutDuplicateValues, x=> Console.WriteLine("[{0}]",',', x));
        //Console.WriteLine("[{0}]", string.Join(',', withoutDuplicateValues));
        Console.WriteLine("Array Count " + ProblemAndSolutionOne.RemoveDuplicates2(nums));
        //How to combine two arrays without duplicate values in C#?
        string[] arr1 = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };
        string[] arr2 = { "Sparrow", "Peacock", "Dove", "Crow" };
        string[] combineArray = ProblemAndSolutionOne.combineTwoArrays(arr1, arr2);
        Console.WriteLine("[{0}]", string.Join(',', combineArray));
        //How to get a comma-separated string from the integer array
        int[] nums1 = { 1, 2, 3, 4 };
        //Console.WriteLine("[{0}]", string.Join(',', nums1));
        Console.WriteLine("{0}", string.Join(',', nums1));
        //How to get second max value from an int array
        int[] nums2 = { 1, -20, -13, 40, 20, 25 };
        Console.WriteLine("Second Largest No. {0}", ProblemAndSolutionOne.getSecondMaxValue(nums2));
        // How to get reverse order strig
        string name = "Mojidul Islam";
        Console.WriteLine("String reverse order= {0}", ProblemAndSolutionOne.getReverseOrderString(name));
        // Find the Height of Stack X to the Power N.
        Console.WriteLine("Power result = {0}", ProblemAndSolutionOne.getBaseToThePower(10, 5));
        //Reverse Words in a String
        string str2 = "the sky is blue";
        //string str2 = "  hello world  ";
        //string str2 = "a good   example";
        //string str2 = "EPY2giL";
        Console.WriteLine("Reverse String " + ProblemAndSolutionOne.ReverseWords(str2));

        int[] numsN = { 2, 5, 7, 11, 15 };
        int target = 9;//two array position sum ..2+7=9
                       //return [0,2]
        var dd = ProblemAndSolutionOne.getArrayIndex(numsN, target);
        Console.WriteLine("Array position [{0}]", string.Join(", ", dd));
        //Sealed classes are used to restrict the inheritance feature of object oriented programming.
        //If you try to derive a class from the SealedClass, you will get an error.
        SealedClass sealedClass = new SealedClass();
        int total = sealedClass.Add(4, 5);
        Console.WriteLine("Total = " + total.ToString());
        //example of Func
        Func<string, string, string> func = ProblemAndSolutionOne.Append;
        string fullName = func("Mojidul", "Islam");
        Console.WriteLine(fullName);
        //example of Action
        Action<string, string> funcAction = ProblemAndSolutionOne.AppendPrint;
        funcAction("Mojidul", "Islam");
        //How to find 5th largest salary using LINQ
        var highestSalary = ProblemAndSolutionOne.Nthhighestsalary(2);
        Console.WriteLine("Array position [{0}]", string.Join(", ", highestSalary));
        //Use of Tuple
        var nameUsing = ProblemAndSolutionOne.NewTuplePattern("", "102", "VII");
        Console.WriteLine("Tuple Use [{0}]", string.Join(", ", nameUsing));
        //Use of Predicate delegate
        ProblemAndSolutionOne.PredicateDelegate();
        //Use of expression
        Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;
        //compile Expression using Compile method to invoke it as Delegate
        Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();
        //Invoke
        bool result = isTeenAger(new Student() { StudentID = 1, StudentName = "Steve", Age = 20 });
        Console.WriteLine("Is Teen Ager " + result);
        //Sum of array
        List<int> arr = new List<int>();
        arr.AddRange(new[] { 1, 2, 3, 6, 7, 3, 8 });
        var totalArrayElement = ProblemAndSolutionOne.SimpleArraySum(arr);
        Console.WriteLine("Total Array Element Sum-" + totalArrayElement.ToString());

        //Test Delegate
        //Provides a good way to encapsulate the methods.
        //Delegates are mainly used in implementing the call-back methods and events.
        TestDelegateSimple delegateObj = new TestDelegateSimple();
        addNumber delegate_obj_add = new addNumber(delegateObj.sum);
        subNumber delegate_obj_substract = new subNumber(delegateObj.subtract);
        // pass the values to the methods by delegate object
        delegate_obj_add(100, 40);
        delegate_obj_substract(100, 60);

        // These can be written as using
        // "Invoke" method
        // delegate_obj_add.Invoke(100, 40);
        // delegate_obj_substract.Invoke(100, 60);

        //multicasting of a delegate
        rectDelegate delegate_with_multicasting_area = new rectDelegate(delegateObj.area);
        //rectDelegate delegate_with_multicasting_perimeter = new rectDelegate(delegateObj.perimeter);
        //no need to above code just write below line
        delegate_with_multicasting_area += delegateObj.perimeter;
        delegate_with_multicasting_area.Invoke(10.2, 12.3);
        Console.WriteLine("Difference");
        delegate_with_multicasting_area.Invoke(12.2, 15.3);

        //Func Delegate with One Parameter
        Func<int, int> Delegate = delegateObj.DoubleValue;
        Console.WriteLine(Delegate(10));

        //Func Delegate with Anonymous Method
        Func<int, int, int> sum1 = delegate (int x, int y)
        {
            return x + y;
        };
        Console.WriteLine(sum1(5, 10));

        //Func Delegate with Lambda Expression
        Func<int, int, int> sum2 = (x, y) => x + y;
        Console.WriteLine(sum2(51, 10));

        Action<int, int> action = delegateObj.SubtractNumbers;
        action(13, 4);

        // Anonymous method using Action delegate
        Action<string> action2 = delegate (string str)
        {
            Console.WriteLine(str);
        };
        action2("Mojidul Islam");

        // Lambda expression using Action delegate
        string ds = "Mojidul Islam";
        Action<string> action1 = str => Console.WriteLine(str);
        action1(ds);

        //predicate test
        predicate_test predicated_del = delegateObj.myfun;
        Console.WriteLine(predicated_del("Hello"));

        ThreadTest thObj = new ThreadTest();
        Thread t1h = new Thread(new ThreadStart(thObj.myTask));
        t1h.Start();

        // Creating and initializing threads
        Thread t1 = new Thread(thObj.work);
        Thread t2 = new Thread(thObj.work);
        Thread t3 = new Thread(thObj.work);

        // Set the priority of threads
        t2.Priority = ThreadPriority.Lowest;
        t3.Priority = ThreadPriority.AboveNormal;
        t1.Start();
        t2.Start();
        t3.Start();

        // Display the priority of threads
        Console.WriteLine("The priority of Thread 1 is: {0}", t1.Priority);
        Console.WriteLine("The priority of Thread 2 is: {0}", t2.Priority);
        Console.WriteLine("The priority of Thread 3 is: {0}", t3.Priority);

        //Implementation of multithreading using Thread class.
        // create a new thread
        Thread t = new Thread(thObj.worker);
        // start the thread
        t.Start();
        // do some other work in the main thread
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("Main thread doing some work");
            Thread.Sleep(100);
        }
        // wait for the worker thread to complete
        t.Join();
        Console.WriteLine("Done");

        Thread thr1 = new Thread(thObj.method1);
        Thread thr2 = new Thread(thObj.method2);
        thr1.Start();
        thr2.Start();

        // Running two tasks concurrently
        Task task1 = Task.Run(() => thObj.PrintNumbers());
        Task task2 = Task.Run(() => thObj.PrintNumbers());
        // Wait for both tasks to complete
        Task.WhenAll(task1, task2).Wait();

        // Example using Threads
        Thread thread1 = new Thread(() => thObj.task("Thread 1"));
        Thread thread2 = new Thread(() => thObj.task("Thread 2"));
        thread1.Start();
        thread2.Start();
        thread1.Join();
        thread2.Join();
        Console.WriteLine("moving to task");
        // Example using Tasks with async/await
        Task.Run(async () => await thObj.RunAsyncTasks()).Wait();
        Console.WriteLine("All tasks completed!!!.");

        // queue a work item to the thread pool
        ThreadPool.QueueUserWorkItem(thObj.Worker1, "Hello, Mojidul!");
        // do some other work in the main thread
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("Main thread doing some work");
            Thread.Sleep(100);
        }
        Console.WriteLine("Done QueueUserWorkItem");


        Console.ReadLine();

    }
}



