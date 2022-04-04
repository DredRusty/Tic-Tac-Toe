
NewGame:

bool win = false; // признак победы

byte hod=0; // счетчик ходов


// Массив 3 на 3 = игровое поле
int[,] TTT = { { 10, 11, 12 }, { 13, 14, 15 }, { 16, 17, 18 } };


// Отрисовываем игровое поле
void igrovoepole(int[,] TTT)

{
    Console.WriteLine();
    Console.WriteLine("Игровое поле");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(TTT[i, j] + "  ");
        }

        Console.WriteLine();
        Console.WriteLine();

    }
    return;
}


//Делаем ход. Передается в checkTurn О или Х.
int turn()
{
    Console.WriteLine("Сделайте ваш ход");
    string? input1 = Console.ReadLine();
    int turnR = Convert.ToInt32(input1);
    return turnR;
}


//Ходит игрок, который ходит О (0). Проверка поля на незанятость Х (1) или О (0). Увеличиваем счетчки ходов и передаем ход.
//Иначе выбрать незанятое поле.
void checkTurn0 (int [,]TTT, int turnR)
{
    if ((turnR == 10) && (TTT[0, 0] != 0) && (TTT[0, 0] != 1))
    {
        TTT[0, 0] = 0;
        hod++;
    }


    else if ((turnR == 11) && (TTT[0, 1] != 0) && (TTT[0, 1] != 1))
    {
        TTT[0, 1] = 0;
        hod++;
    }

    else if ((turnR == 12) && (TTT[0, 2] != 0) && (TTT[0, 2] != 1))
    {
        TTT[0, 2] = 0;
        hod++;
    }

    else if ((turnR == 13) && (TTT[1, 0] != 0) && (TTT[1, 0] != 1))
    {
        TTT[1, 0] = 0;
        hod++;
    }

    else if ((turnR == 14) && (TTT[1, 1] != 0) && (TTT[1, 1] != 1))
    {
        TTT[1, 1] = 0;
        hod++;
    }

    else if ((turnR == 15) && (TTT[1, 2] != 0) && (TTT[1, 2] != 1))
    {
        TTT[1, 2] = 0;
        hod++;
    }

    else if ((turnR == 16) && (TTT[2, 0] != 0) && (TTT[2, 0] != 1))
    {
        TTT[2, 0] = 0;
        hod++;
    }

    else if ((turnR == 17) && (TTT[2, 1] != 0) && (TTT[2, 1] != 1))
    {
        TTT[2, 1] = 0;
        hod++;
    }

    else if ((turnR == 18) && (TTT[2, 2] != 0) && (TTT[2, 2] != 1))
    {
        TTT[2, 2] = 0;
        hod++;
    }

    else checkTurn0(TTT, turn());

    return;
}


//Ходит игрок, который ходит Х (1). Проверка поля на незанятость Х (1) или О (0). Увеличиваем счетчки ходов и передаем ход.
//Иначе выбрать незанятое поле. 
void checkTurn1(int[,] TTT, int turnR)
{
    if ((turnR == 10) && (TTT[0, 0] != 0) && (TTT[0, 0] != 1))
    {
        TTT[0, 0] = 1;
        hod++;
    }


    else if ((turnR == 11) && (TTT[0, 1] != 0) && (TTT[0, 1] != 1))
    {
        TTT[0, 1] = 1;
        hod++;
    }

    else if ((turnR == 12) && (TTT[0, 2] != 0) && (TTT[0, 2] != 1))
    {
        TTT[0, 2] = 1;
        hod++;
    }

    else if ((turnR == 13) && (TTT[1, 0] != 0) && (TTT[1, 0] != 1))
    {
        TTT[1, 0] = 1;
        hod++;
    }

    else if ((turnR == 14) && (TTT[1, 1] != 0) && (TTT[1, 1] != 1))
    {
        TTT[1, 1] = 1;
        hod++;
    }

    else if ((turnR == 15) && (TTT[1, 2] != 0) && (TTT[1, 2] != 1))
    {
        TTT[1, 2] = 1;
        hod++;
    }

    else if ((turnR == 16) && (TTT[2, 0] != 0) && (TTT[2, 0] != 1))
    {
        TTT[2, 0] = 1;
        hod++;
    }

    else if ((turnR == 17) && (TTT[2, 1] != 0) && (TTT[2, 1] != 1))
    {
        TTT[2, 1] = 1;
        hod++;
    }

    else if ((turnR == 18) && (TTT[2, 2] != 0) && (TTT[2, 2] != 1))
    {
        TTT[2, 2] = 1;
        hod++;
    }

    else checkTurn1(TTT, turn());

    return;
}


// проверка на WIN
bool winOrNotWin(int[,] TTT)
{
    if (
        (TTT[0, 0] == TTT[0, 1] && TTT[0, 1] == TTT[0, 2]) || // первая горизонталь 
        (TTT[0, 0] == TTT[1, 1] && TTT[1, 1] == TTT[2, 2]) || // диагональ слева направо
        (TTT[0, 0] == TTT[1, 0] && TTT[1, 0] == TTT[2, 0]) || // первая вертикаль
        (TTT[1, 0] == TTT[1, 1] && TTT[1, 1] == TTT[1, 2]) || // вторая горизонталь
        (TTT[2, 0] == TTT[2, 1] && TTT[2, 1] == TTT[2, 2]) || // третья горизонталь
        (TTT[0, 1] == TTT[1, 1] && TTT[1, 1] == TTT[2, 1]) || // вторая вертикаль
        (TTT[0, 2] == TTT[1, 2] && TTT[1, 2] == TTT[2, 2]) || // третья вертикаль
        (TTT[0, 2] == TTT [1,1] && TTT [1,1] == TTT [2,0])    // диагональ справа налево
        )
    {
        win = true;
    }

    else win = false;

    return win;
}


// сообщение о победившем игроке или конце партии без победителя
void message(int hod)
{ 
    
    if ((hod + 1) == 10)
    {
    Console.WriteLine("Партия закончена без победителя");
    }


   else if (hod % 2 == 0)
    {
        Console.WriteLine("Победил игрок X");
    }

    else if (hod % 2 == 1)
    {
        Console.WriteLine("Победил игрок O");
    }

    return;
}



igrovoepole(TTT);


// пока нет победителя или не закончились ходы .....
    while ((win == false) & ((hod+1) !=10))

    {
        if (hod % 2 == 0)
        {
            Console.WriteLine("Игрок О делает ход");
            checkTurn0(TTT, turn());
            winOrNotWin(TTT);
            igrovoepole(TTT);
        }

        else if (hod % 2 == 1)
        {
            Console.WriteLine("Игрок Х делает ход");
            checkTurn1(TTT, turn());
            winOrNotWin(TTT);
            igrovoepole(TTT);
        }

    }

message(hod);


// Выход из игры или новая партия


    Console.WriteLine("Хотите сыграть еще раз? Да - нажмите Y, Нет - нажмите N");
PressKey:
    string? choice = Console.ReadLine();


    if (choice == "Y")

    {
        Console.WriteLine("Запускаем новую партию!");
        goto NewGame;
    }

    else if (choice == "N")
    {
        Console.WriteLine("До свидания!");
    }

    else
    {
        Console.WriteLine("Сделайте свой выбор!");
        goto PressKey;
    }





// подключить рандом на компа


