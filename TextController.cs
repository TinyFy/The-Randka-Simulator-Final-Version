using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    //31 state'�w
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

        text.text = "Znajdujesz si� przed wej�ciem do ekskluzywnej restauracji Ryneczek Lidla, \n" +
            " jeste� tam wraz z dziewczyn�, kt�r� pozna�e� wczoraj na imprezie w pubie, \n" +
            "problem w tym, �e zapomnia�e� zarezerwowa� stolik... \n\n" +
            "Naci�nij Enter, aby zagada� do laski";

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
            " Porusza mnie tylko u�miech Bojdysa` - powiedzia�e� \n" +
            "A dziewczyna u�miechn�a si�.\n\n" +
            "Naci�nij Enter, aby podej�� do bramki";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_gate; }
    }

    private void state_talkone()
    {
        text.text = "Chcia�e� si� odezwa�, ale w momencie u�wiadomi�e� sobie, �e nie wiesz,\n" +
            " co tak w�a�ciwie chcia�e� powiedzie�, wymy� co� na szybko!\n\n" +
            "Naci�nij 1, aby zapoda� jaki� cytat z ksi��ki, czy co�...\n" +
            "Naci�nij 2, aby j� skomplementowa�\n" +
            "Naci�nij 3, aby zwr�ci� uwag� na �adn� pogod�";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_book; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_compliment; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_weather; }
    }
    private void state_compliment()

    {
        text.text = "`Masz bardzo pi�kne oczy Aniu`\n" +
            " - powiedzia�e�, a dziewczyna si� u�miechn�a\n\n" +
            "Naci�nij Enter, aby podej�� do bramki";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_gate; }
    }
    private void state_gate()
    {
        text.text = "Okej, �wietny pocz�tek kowboju, da�e� rad�, \n" +
            " podchodzicie do bramki, przy kt�rej stoi zakapturzony ochroniarz, \n" +
            "ale nadal nie macie jak wej��. Musisz co� wykombinowa�.\n\n" +
            "Naci�nij 1, aby, wej�� przez tylne okno\n" +
            "Naci�nij 2, aby da� ochroniarzowi w �ap�\n" +
            "Naci�nij 3, aby podej�� i liczy�, �e nie narobisz sobie wstydu";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_window; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_pay; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_miracle; }
    }
    private void state_window()
    {
        text.text = "Okno okaza�o si� by� zamkni�te, \n" +
            "Dziewczyna oburzy�a si� i o ma�o nie posz�� do domu\n" +
            "Uwa�aj nast�pnym razem!\n\n" +
            "Naci�nij Enter, aby uda� si� z powrotem w kierunku bramki.";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_gatetwo; }
    }
    private void state_gatetwo()
    {
        text.text = "Okej, teraz zosta�y ju� tylko dwie opcje,\n" +
            "Zwa�ywszy na okoliczno�ci, nie ma ju� chyba co ryzykowa�\n" +
            "Chyba najlepiej jest da� mu w �ap�\n\n" +
            "Naci�nij 1, aby da� ochroniarzowi w �ap�\n" +
            "Naci�nij 2, aby podej�� i liczy�, �e was wpuszcz�";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_pay; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_miracle; }
    }
    private void state_miracle()
    {
        text.text = "Masz sporo szcz�cia go�ciu, akurat tw�j stary znajomy\n" +
            "ma teraz zmian� i okazuje si�, �e pracuje tu na ochronie\n\n" +
            "Naci�nij Enter, aby wej�� do �rodka";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_friend; }

    }
    private void state_pay()
    {
        text.text = "Podchodzisz, ruchem od spodu dotykasz ochroniarza\n" +
            "Ten widzi pod spodem kilka st�wek, patrzy ci w oczy\n" +
            "I BUM, wyrzuca was, a dziewczyna si� do ciebie nie odzywa\n" +
            "Gratulacje Mistrzu!\n\n" +
            "Naci�nij Esc, aby rozpocz�� od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }

    }
    private void state_weather()
    {
        text.text = "`Pi�kna pogoda, nieprawda�?` - zapyta�e�\n" +
            "`Zai�cie` - odpowiada dziewczyna �artobliwie\n\n" +
            "Naci�nij Enter, aby podej�� do bramki";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_gate; }

    }
    private void state_friend()
    {
        text.text = "No i posz�o jak z p�atka, tylko\n" +
            "co teraz zrobi�?\n\n" +
            "Naci�nij 1, aby powiedzie� co� dziwnego\n" +
            "Naci�nij 2, aby odsun�� dziewczynie krzes�o jak `D�entelmen`\n" +
            "Naci�nij 3, aby usi��� jak cz�owiek";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_weird; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_chair; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_sit; }
    }
    private void state_chair()
    {
        text.text = "Dziewczyna robi zdziwion� min�,\n" +
            "a ty p�kasz i uciekasz si� rozp�aka�\n" +
            "na ramieniu mamusi. Mi�czak z ciebie.\n\n" +
            "Naci�nij Esc, aby rozpocz�� od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
    private void state_weird()
    {
        text.text = "Laska nie zwraca na to uwagi\n" +
            "i u�miecha si� do ciebie. Widzisz podchodz�cego\n" +
            "do stolika kelnera\n\n" +
            "Naci�nij Enter, aby si� u�miechn��";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_waiter; }

    }
    private void state_sit()
    {
        text.text = "Siadasz jak cz�owiek, wi�c nic\n" +
            "si� raczej nie dzieje. Widzisz podchodz�cego\n" +
            "do stolika kelnera\n\n" +
            "Naci�nij Enter, aby si� u�miechn��";
        if (Input.GetKeyDown(KeyCode.Return)) { myState = States.state_waiter; }
    }
    private void state_waiter()
    {
        text.text = "Kelner pyta co poda�, a ty odpowiadasz...\n\n" +
            "1 - Poprosz� sam� wod�\n" +
            "2 - Poprosz� najlepsze wino\n" +
            "3 - Co zam�wi� Aniu?";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_water; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_water; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_ask; }
    }
    private void state_water()
    {
        text.text = "Dziewczyna jest u�miechni�ta\n" +
            "To by� dobry krok :) Teraz siedzicie i dobrze si�\n" +
            "bawicie, po kilkunastu minutach zamawiecie co� konkretniejszego\n" +
            "Teraz pozosta�a ju� tylko sprawa rachunku\n\n" +
            "Naci�nij 1, aby zap�aci� za wszystko i wyj��\n" +
            "Naci�nij 2, aby powiedzie� dziewczynie komplement\n" +
            "Naci�nij 3, aby podzieli� rachunek\n" +
            "Naci�nij 4, aby zap�aci� za siebie";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_takeabillpay; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_complimenttwo; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_share; }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { myState = States.state_payforyourself; }
    }
    private void state_takeabillpay()
    {
        text.text = "Oboje wychodzicie zadowolenie i dziewczyna\n" +
            "chce si� um�wi� na kolejn� randk�, u niej w domu\n\n" +
            "Naci�nij Esc, aby rozpocz�� od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
    private void state_complimenttwo()
    {
        text.text = "M�wisz dziewczynie komplement, a ta\n" +
            "chce zap�aci� za wszystko\n\n" +
            "Naci�nij 1, aby przyj�� propozycj�\n" +
            "Naci�nij 2, aby odm�wi�";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_takeabillpay; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_disagree; }
    }
    private void state_disagree()
    {
        text.text = "P�acisz za wszystko i oboje wychodzicie\n" +
            "dziewczyna nie bawi�a si� �le,\n" +
            "ale nie chce um�wi� si� ponownie\n\n" +
            "Naci�nij Esc, aby rozpocz�� od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
    private void state_share()
    {
        text.text = "Dziewczyna oburza si� i wychodzi\n" +
            "Bo zjad�e� 10 razy wi�cej. S�abe zagranie stary...\n\n" +
            "Naci�nij Esc, aby rozpocz�� od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
    private void state_payforyourself()
    {
        text.text = "Dziewczyna te�, chce zap�aci� za siebie\n" +
            "wi�c oboje nie macie z tym problemu,\n" +
            "razem wychodzicie i rozmawiacie na zewn�trz...\n\n" +
            "Naci�nij Esc, aby rozpocz�� od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
        private void state_ask()
        {
        text.text = "Robisz s�abe wra�enie na dziewczynie\n" +
            "wysz�o, �e nie umiesz samemu podj��\n" +
            "decyzji, a na koniec dowalasz jeszcze\n" +
            "co� dziwnego i dziewczyna wychodzi.\n\n" +
            "Naci�nicj Esc, aby rozpocz�� od nowa";
        if (Input.GetKeyDown(KeyCode.Escape)) { myState = States.state_entry; }
    }
}


