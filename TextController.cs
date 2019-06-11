using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    //31 state'ów
    private enum States
    {
        state_entry, state_talkone, state_compliment, state_book, state_weather,
        state_gate, state_window, state_windowlocked, state_pay, state_miracle, state_gatetwo, state_paytwo,
        state_miracletwo, state_friend, state_weird, state_chair, state_sit, state_noattention, state_waiter,
        state_water, state_wine, state_ask, state_smile, state_fun, state_takeabillpay, state_complimenttwo,
        state_share, state_payforyourself, state_shewantstopay, state_agree, state_disagree
    }
    States myState;
    void state_entry()
    {

        text.text = "Znajdujesz siê przed wejœciem do ekskluzywnej restauracji Ryneczek Lidla, \n" +
            " jesteœ tam wraz z dziewczyn¹, któr¹ pozna³eœ wczoraj na imprezie w pubie, \n" +
            "problem w tym, ¿e zapomnia³eœ zarezerwowaæ stolik... \n\n" +
            "Naciœnij Enter, aby zagadaæ do laski";

        if (Input.GetKeyDown(KeyCode.Return))
        {
            myState = States.state_talkone;
        }
    }

    void Start()
    {
        myState = States.state_entry;

    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.state_entry) { state_entry(); }
        else if (myState == States.state_talkone) { state_talkone(); }
        else if (myState == States.state_gate) { state_gate(); }
        else if (myState == States.state_gatetwo) { state_gatetwo(); }
        else if (myState == States.state_compliment) { state_compliment(); }
        else if (myState == States.state_waiter) { state_waiter(); }
        else if (myState == States.state_miracle) { state_miracle(); }
        else if (myState == States.state_chair) { state_chair(); }
        else if (myState == States.state_payforyourself) { state_payforyourself(); }
        else if (myState == States.state_share) { state_share(); }
        else if (myState == States.state_takeabillpay) { state_takeabillpay(); }
        else if (myState == States.state_complimenttwo) { state_complimenttwo(); }
        else if (myState == States.state_pay) { state_pay(); }
        else if (myState == States.state_disagree) { state_disagree(); }
        else if (myState == States.state_water) { state_water(); }
        else if (myState == States.state_weather) { state_weather(); }
        else if (myState == States.state_sit) { state_sit(); }
        else if (myState == States.state_window) { state_window(); }
        else if (myState == States.state_weird) { state_weird(); }
        else if (myState == States.state_friend) { state_friend(); }
        else if (myState == States.state_book) { state_book(); }
        else if (myState == States.state_ask) { state_ask(); }
        //else if (myState = States.state_entry){state_entry(); }

    }
    private void state_book()
    {
        text.text = "`Na dworze jasno, na twarzy rysa.\n" +
            " Porusza mnie tylko uœmiech Bojdysa` - powiedzia³eœ \n" +
            "A dziewczyna uœmiechnê³a siê.\n\n" +
            "Naciœnij Enter, aby podejœæ do bramki";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_gate; }
    }

    private void state_talkone()
    {
        text.text = "Chcia³eœ siê odezwaæ, ale w momencie uœwiadomi³eœ sobie, ¿e nie wiesz,\n" +
            " co tak w³aœciwie chcia³eœ powiedzieæ, wymyœ coœ na szybko!\n\n" +
            "Naciœnij 1, aby zapodaæ jakiœ cytat z ksi¹¿ki, czy coœ...\n" +
            "Naciœnij 2, aby j¹ skomplementowaæ\n" +
            "Naciœnij 3, aby zwróciæ uwagê na ³adn¹ pogodê";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_book; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_compliment; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_weather; }
    }
    private void state_compliment()

    {
        text.text = "`Masz bardzo piêkne oczy Aniu`\n" +
            " - powiedzia³eœ, a dziewczyna siê uœmiechnê³a\n\n" +
            "Naciœnij Enter, aby podejœæ do bramki";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_gate; }
    }
    private void state_gate()
    {
        text.text = "Okej, œwietny pocz¹tek kowboju, da³eœ radê, \n" +
            " podchodzicie do bramki, przy której stoi zakapturzony ochroniarz, \n" +
            "ale nadal nie macie jak wejœæ. Musisz coœ wykombinowaæ.\n\n" +
            "Naciœnij 1, aby, wejœæ przez tylne okno\n" +
            "Naciœnij 2, aby daæ ochroniarzowi w ³apê\n" +
            "Naciœnij 3, aby podejœæ i liczyæ, ¿e nie narobisz sobie wstydu";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_window; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_pay; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_miracle; }
    }
    private void state_window()
    {
        text.text = "Okno okaza³o siê byæ zamkniête, \n" +
            "Dziewczyna oburzy³a siê i o ma³o nie posz³¹ do domu\n" +
            "Uwa¿aj nastêpnym razem!\n\n" +
            "Naciœnij Enter, aby udaæ siê z powrotem w kierunku bramki.";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_gatetwo; }
    }
    private void state_gatetwo()
    {
        text.text = "Okej, teraz zosta³y ju¿ tylko dwie opcje,\n" +
            "Zwa¿ywszy na okolicznoœci, nie ma ju¿ chyba co ryzykowaæ\n" +
            "Chyba najlepiej jest daæ mu w ³apê\n\n" +
            "Naciœnij 1, aby daæ ochroniarzowi w ³apê\n" +
            "Naciœnij 2, aby podejœæ i liczyæ, ¿e was wpuszcz¹";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_pay; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_miracle; }
    }
    private void state_miracle()
    {
        text.text = "Masz sporo szczêœcia goœciu, akurat twój stary znajomy\n" +
            "ma teraz zmianê i okazuje siê, ¿e pracuje tu na ochronie\n\n" +
            "Naciœnij Enter, aby wejœæ do œrodka";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_friend; }

    }
    private void state_pay()
    {
        text.text = "Podchodzisz, ruchem od spodu dotykasz ochroniarza\n" +
            "Ten widzi pod spodem kilka stówek, patrzy ci w oczy\n" +
            "I BUM, wyrzuca was, a dziewczyna siê do ciebie nie odzywa\n" +
            "Gratulacje Mistrzu!\n\n" +
            "Naciœnij Esc, aby rozpocz¹æ od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }

    }
    private void state_weather()
    {
        text.text = "`Piêkna pogoda, nieprawda¿?` - zapyta³eœ\n" +
            "`Zaiœcie` - odpowiada dziewczyna ¿artobliwie\n\n" +
            "Naciœnij Enter, aby podejœæ do bramki";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_gate; }

    }
    private void state_friend()
    {
        text.text = "No i posz³o jak z p³atka, tylko\n" +
            "co teraz zrobiæ?\n\n" +
            "Naciœnij 1, aby powiedzieæ coœ dziwnego\n" +
            "Naciœnij 2, aby odsun¹æ dziewczynie krzes³o jak `D¿entelmen`\n" +
            "Naciœnij 3, aby usi¹œæ jak cz³owiek";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_weird; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_chair; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_sit; }
    }
    private void state_chair()
    {
        text.text = "Dziewczyna robi zdziwion¹ minê,\n" +
            "a ty pêkasz i uciekasz siê rozp³akaæ\n" +
            "na ramieniu mamusi. Miêczak z ciebie.\n\n" +
            "Naciœnij Esc, aby rozpocz¹æ od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
    private void state_weird()
    {
        text.text = "Laska nie zwraca na to uwagi\n" +
            "i uœmiecha siê do ciebie. Widzisz podchodz¹cego\n" +
            "do stolika kelnera\n\n" +
            "Naciœnij Enter, aby siê uœmiechn¹æ";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_waiter; }

    }
    private void state_sit()
    {
        text.text = "Siadasz jak cz³owiek, wiêc nic\n" +
            "siê raczej nie dzieje. Widzisz podchodz¹cego\n" +
            "do stolika kelnera\n\n" +
            "Naciœnij Enter, aby siê uœmiechn¹æ";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_waiter; }
    }
    private void state_waiter()
    {
        text.text = "Kelner pyta co podaæ, a ty odpowiadasz...\n\n" +
            "1 - Poproszê sam¹ wodê\n" +
            "2 - Poproszê najlepsze wino\n" +
            "3 - Co zamówiæ Aniu?";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_water; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_water; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_ask; }
    }
    private void state_water()
    {
        text.text = "Dziewczyna jest uœmiechniêta\n" +
            "To by³ dobry krok :) Teraz siedzicie i dobrze siê\n" +
            "bawicie, po kilkunastu minutach zamawiecie coœ konkretniejszego\n" +
            "Teraz pozosta³a ju¿ tylko sprawa rachunku\n\n" +
            "Naciœnij 1, aby zap³aciæ za wszystko i wyjœæ\n" +
            "Naciœnij 2, aby powiedzieæ dziewczynie komplement\n" +
            "Naciœnij 3, aby podzieliæ rachunek\n" +
            "Naciœnij 4, aby zap³aciæ za siebie";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_takeabillpay; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_complimenttwo; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_share; }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.state_payforyourself; }
    }
    private void state_takeabillpay()
    {
        text.text = "Oboje wychodzicie zadowolenie i dziewczyna\n" +
            "chce siê umówiæ na kolejn¹ randkê, u niej w domu\n\n" +
            "Naciœnij Esc, aby rozpocz¹æ od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
    private void state_complimenttwo()
    {
        text.text = "Mówisz dziewczynie komplement, a ta\n" +
            "chce zap³aciæ za wszystko\n\n" +
            "Naciœnij 1, aby przyj¹æ propozycjê\n" +
            "Naciœnij 2, aby odmówiæ";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_takeabillpay; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_disagree; }
    }
    private void state_disagree()
    {
        text.text = "P³acisz za wszystko i oboje wychodzicie\n" +
            "dziewczyna nie bawi³a siê Ÿle,\n" +
            "ale nie chce umówiæ siê ponownie\n\n" +
            "Naciœnij Esc, aby rozpocz¹æ od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
    private void state_share()
    {
        text.text = "Dziewczyna oburza siê i wychodzi\n" +
            "Bo zjad³eœ 10 razy wiêcej. S³abe zagranie stary...\n\n" +
            "Naciœnij Esc, aby rozpocz¹æ od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
    private void state_payforyourself()
    {
        text.text = "Dziewczyna te¿, chce zap³aciæ za siebie\n" +
            "wiêc oboje nie macie z tym problemu,\n" +
            "razem wychodzicie i rozmawiacie na zewn¹trz...\n\n" +
            "Naciœnij Esc, aby rozpocz¹æ od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
        private void state_ask()
        {
        text.text = "Robisz s³abe wra¿enie na dziewczynie\n" +
            "wysz³o, ¿e nie umiesz samemu podj¹æ\n" +
            "decyzji, a na koniec dowalasz jeszcze\n" +
            "coœ dziwnego i dziewczyna wychodzi.\n\n" +
            "Naciœnicj Esc, aby rozpocz¹æ od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
}


