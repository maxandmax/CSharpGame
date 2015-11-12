using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;
using Microsoft.DirectX.AudioVideoPlayback;


namespace Distance
{
    public partial class Game1 : Form
    {
        Random rand = new Random();
        
        bool playGame = false; // Если переменная отключена игра закончена или еще не начата

        // Указываем графическую область для работы 
        Graphics g;

        // Объект в памяти
        public static System.Drawing.Bitmap BgObj, mObj, colisObj, catObj, resObj, tbObj_g, obj_bomb; // Области память для гр. объектов

        SoundPlayer repulsion = new SoundPlayer();

        Rectangle tb_Obj, mv_Obj, bomb_Obj; // Области для объекта который гоняется за другими объектами
        public static int maincObj = 3; // Количество объектов указаных в системе. Нужно, если пользователь начал игру с начала

        public static int cObj = maincObj; // количество объектов за которыми гоняются
        public static int rObj = 1; // Количество объектов для воскрешения объектовы

        string[] colDirs = new string[cObj]; //Направления каждого убегающего объекта
        string[] resDirs = new string[rObj]; // Направление объектов которые воскрешают кубики

        Rectangle[] arrayColObj = new Rectangle[cObj]; // Область объектов за которыми гоняется пользователь их несколько штук
        Rectangle[] resurectObj = new Rectangle[rObj]; // Область объектов которые возвращают к жизни пойманные кубики

        string direction = ""; // Направление движения объекта
        public static bool useQuestions = true; // ИСПОЛЬЗОВАНИЕ ВОПРОСОВ ВЗЯТЫХ В ФАЙЛЕ !!!
        int timerOrig = 0;

        public static int winVertSize = 800; // Горизонтальное окно
        public static int winHoriSize = 800; // Вертикальное окно

        // Массив для указания элементам, что их поймали
        bool[] catched = new bool[cObj];

        int o = 70;
        int a = 70;

        int timer = 1000; // счетчик отсчитывает время 

        int finalResultGood = 0; // Конечный результат
        int finalResultBad = 0; // Конечный рельтат
        public static bool useTimer = false;

        int maxStep = 50; // Максимальный шаг через который будет меняться шаг 
        int step = 0; // cчетчик шагов

        // Скорость объектов всех трех
        public static int mainObjSpeed = 8;   // Главная скорость всех объектов 
        public static int catchObjspeed = mainObjSpeed;  // Скорость устанавливаемая пользователем
        int resurectObjspeed = catchObjspeed; // Нетральные объекты которые могут возвращят объекты

        int widthHeightSquare = 17; // Размеры кубиков высота/ширина
        int level = 1; // Уровень установленный системой
        bool oddEven = false;

        bool usetboost = false; // используем ускорение
        int tBoostTime = 100; // Время отведенное для ускорения
        int tempBoost = 0; // Счетчик для завершения ускорения
        int boostObjspeed = 5; // Скорость объекта при ускорении

        bool getQuestion = false;
        bool pause = false;
        public static int maxColObj = 25;
        public static bool endBoost = false;
        public static string bground = "boot";
        bool soundEnabled = true;

        public bool useImpactObjs = true;
        
        static int impactObj = 25;
        public static System.Drawing.Bitmap obj;
        Rectangle[] im_obj = new Rectangle[impactObj];

        bool pictureMove = true;

        int ab = -200;
        int ba = -200;

        int[] looperFix = new int[cObj];

        Label questView = new Label(); // Лейбл куда выводится сообщение с вопросом
        TextBox textAns = new TextBox(); // Текстовое поле для ответа
        Button ansBtn = new Button(); // Кнопка для ответа

        Button contBtn = new Button(); // Кнопка продолжения

        Button repeat = new Button(); // Запустить заного
        Label lblres = new Label();  // Информационое табло

        // Устанавливаем счетчик штрафных очков и бонусов
        int badScore = 0;
        int goodScore = 0;

        int qNum = 0;
        int QuestionAmount = 0;

        int showTime = 10;
        int showTincr = 0;
        bool sh = false;

        string[] questions = new string[1];
        string[] answers = new string[1];

        bool show = false;

        public static bool useLandObjs = true;

        public static bool dontUseAutomaticMoving = false;

        private void defBack()
        {
            switch (bground)
            {
                case "pBlue":
                    obj = Properties.Resources.landscape_blue;
                    BgObj = Properties.Resources.bg_blue;
                    this.BackgroundImage = Properties.Resources.bg_blue;
                    break;
                case "pGreen":
                    obj = Properties.Resources.landscape_green;
                    BgObj = Properties.Resources.bg_green;
                    this.BackgroundImage = Properties.Resources.bg_green;
                    break;
                case "pRed":
                    obj = Properties.Resources.landscape_red;
                    BgObj = Properties.Resources.bg_red;
                    this.BackgroundImage = Properties.Resources.bg_red;
                    break;
                case "pPink":
                    obj = Properties.Resources.landscape_pink;
                    BgObj = Properties.Resources.bg_pink;
                    this.BackgroundImage = Properties.Resources.bg_pink;
                    break;
                case "pDefault":
                    obj = Properties.Resources.landscape_green;
                    BgObj = Properties.Resources.bg_default;
                    this.BackgroundImage = Properties.Resources.bg_default;
                    break;
                case "boot":
                    obj = Properties.Resources.landscape_green;
                    BgObj = Properties.Resources.bg_default_boot;
                    this.BackgroundImage = Properties.Resources.bg_default_boot;
                    break;
                default:
                    obj = Properties.Resources.landscape_green;
                    BgObj = Properties.Resources.bg_default;
                    this.BackgroundImage = Properties.Resources.bg_default;
                    break;
            }

            this.ClientSize = new System.Drawing.Size(new Point(winHoriSize, winVertSize));
            g = Graphics.FromImage(this.BackgroundImage);

        }

        public Game1()
        {
            InitializeComponent();

            timerOrig = timer;
            
            mObj = Properties.Resources.mainObject;
            colisObj = Properties.Resources.colObj;
            catObj = Properties.Resources.catObj;
            resObj = Properties.Resources.resObj;
            tbObj_g = Properties.Resources.tbObj;
            obj_bomb = Properties.Resources.bomb;
            obj = Properties.Resources.landscape_green;

            defBack();
            bground = "default";

            getQuestions();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            repulsion.Stream = Properties.Resources.begin;

            mv_Obj.Width = widthHeightSquare;
            mv_Obj.Height = widthHeightSquare;

            tb_Obj.Width = widthHeightSquare;
            tb_Obj.Height = widthHeightSquare;

            bomb_Obj.Width = widthHeightSquare;
            bomb_Obj.Height = widthHeightSquare;

            t_mvObj.Interval = 100;
            t_Count.Interval = 100;

            // Устанавливаем количество вопросов указанных в другом массиве

            if (useQuestions)
            {
                if (MessageBox.Show("Хотите ли вы использовать вопросы в игре?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { useQuestions = true; }
                else
                { useQuestions = false; }
            }
        }

        private void genImpactObjs(bool gen=false)
        {
            // Если включенны объекты - преграды то генерируем их, а в к вконце рауда или в конце игры удаляем 

            if (useImpactObjs)
            {

                for (int i = 0; i < impactObj; i++)
                {
                    if (gen)
                    {
                        // место положение объекта
                        im_obj[i].X = rand.Next(0, 800);
                        im_obj[i].Y = rand.Next(0, 800);

                        // Размеры 
                        im_obj[i].Width = rand.Next(10, 70);
                        im_obj[i].Height = rand.Next(10, 70);
                    }
                    else
                    {
                        im_obj[i].X = im_obj[i].X;
                        im_obj[i].Y = im_obj[i].Y;

                        im_obj[i].Width = im_obj[i].Width;
                        im_obj[i].Height = im_obj[i].Height;
                    }

                    g.DrawImage(obj, im_obj[i].X, im_obj[i].Y, im_obj[i].Width, im_obj[i].Height);
                }

                    /*    
                    var obj_N = new List<PictureBox>();
                    for (int i = 0; i < 10; i++)
                    {
                        obj_N.Add(new PictureBox() { Location = new Point(19, 69) });
                    }
                    // Нужен массив? пожалуйста:
                    var arr = obj_N.ToArray();
                    */
            }
        }

        private void fixTextures(Rectangle[] var1, Rectangle[] var2, int objects)
        {
            int i = 0;

            int horizontal = winHoriSize;
            int vertical = winVertSize;

            while(true)
            {
                var1[i].X = rand.Next(1, horizontal);
                var1[i].Y = rand.Next(1, vertical);

                var1[i].Width = widthHeightSquare;
                var1[i].Height = widthHeightSquare;

                bool passed = false;

                for (int y = 0; y < impactObj; y++) { if (clashDetect(var1[i], var2[y]) == false) { passed = true; } }

                if (passed) i++;
                if (i == objects) break;
            }
        }

        private void levelChoise()
        {
            /*
              Запускается первый раз когда пользователь запускает игру
              Запускается второй раз когда собраны все объекты
            */

            if (soundEnabled == true)
            {
                repulsion.Play();
                repulsion.PlayLooping();
                soundlbl.Image = Properties.Resources.sound_on;
            }
            else
                soundlbl.Image = Properties.Resources.sound_off;

            catchObjspeed = mainObjSpeed;
            resurectObjspeed = mainObjSpeed;

            if (useTimer == false) counter.Text = "";

            infoPanel.BackgroundImage = null;

            // Устанавливаем счетчики на начало, а также, если уже играли сбрасываем кнопку повтора
            good.Text = "0";
            bad.Text = "0";

            if (useLandObjs)
                genImpactObjs(useLandObjs);
            else
            {
                for (int i = 0; i < impactObj; i++)
                {
                    im_obj[i].Y = -300;
                    im_obj[i].X = -300;
                }
            }

            // Четное/Нечетное устанавливаем в false
            oddEven = false;
            tempBoost = 0;

            finalResultGood = finalResultGood + goodScore;
            finalResultBad = finalResultBad + badScore;

            // Обновляем счетчик уровня на ноль
            goodScore = 0;
            badScore = 0;

            usetboost = false; // используем ускорение
            tempBoost = 0; // Счетчик для завершения ускорения

            timer = timerOrig + (level * 100);

            direction = "";

            // При каждом новом уровне увиличиваем кол-во объектов
            if (level != 1)
            {
                cObj = cObj + 2;
                // Если число четное добавляем новое воскрешающий объект
                if ((level % 2) == 0) rObj++;
            }

            resDirs = new string[rObj];

            resurectObj = new Rectangle[rObj]; // Область объектов которые возвращают к жизни пойманные кубики

            for (int i = 0; i < rObj; i++)
            {
                resDirs[i] = changeDirection(resDirs[i], true);
            }

            fixTextures(resurectObj, im_obj, rObj);
            
            arrayColObj = new Rectangle[cObj];
            catched = new bool[cObj];
            colDirs = new string[cObj];

            fixTextures(arrayColObj, im_obj, cObj);

            looperFix = new int[cObj];

            // даем объектам которые мы хотим отловить, параметры: Место положение, Направление, Размеры и параметр не отловленны
            for (int i = 0; i < cObj; i++)
            {
                // Даем рандомное направление объекту и устанавливаем все объекты статусом не отловлен.
                colDirs[i] = changeDirection(colDirs[i], true);
                catched[i] = false;
            }

            lvlbl.Text = Convert.ToString("L:" + level);

            showInfo.Enabled = true;

            oddEven = true;
            genRandObjPlace();

            if (cObj >= maxColObj) { gameover(); } else { playSound("levelChanges"); }
        }

        public void начатьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Начинаем игру! */

            // Включает музыку

            defBack();
            levelChoise();


            lvlbl.Image = Properties.Resources.right_btn;
            good.Image = Properties.Resources.middle_btn;
            bad.Image = Properties.Resources.left_btn;

            label1_info.Enabled = true;
            label1_info.Text = "?";
            label1_info.Image = Properties.Resources.middle_btn;


            timer = 1000; // Время которое дается пользователю для отлова всех объектов

            finalResultGood = 0;
            finalResultBad = 0;

            // указываем первоначальные кординнаты движушемуся объекту
            mv_Obj.Y = 350;
            mv_Obj.X = 150;

            settings.Enabled = false;
            gameBegin.Enabled = false;
            endGame.Enabled = true;

            startStopGame(true);
            soundlbl.Enabled = true;

            lvlbl.Text = Convert.ToString("L:" + level);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (useTimer) counter.Text = Convert.ToString(timer);

            // Проверяем таймер, если кончилось время
            if (0 >= timer)
            {
                if (useTimer) gameover();
            }
            else timer--;

            if (a < 0)
            {
                if (endBoost) { catchObjspeed++; }
 
                genRandObjPlace(true);
            } else a--;
        }

        private void genRandObjPlace(bool change = false) 
        {
            a = o;

            if (oddEven)
            {
                oddEven = false;
                bomb_Obj.X = rand.Next(1, winHoriSize);
                bomb_Obj.Y = rand.Next(1, winVertSize);
            }
            else
            {
                oddEven = true;
                tb_Obj.X = rand.Next(1, winHoriSize);
                tb_Obj.Y = rand.Next(1, winVertSize);
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!soundEnabled)
            {
                soundlbl.Image = Properties.Resources.sound_on;
                soundEnabled = true;

                repulsion.Play();
                repulsion.PlayLooping();

                return;
            }

            soundlbl.Image = Properties.Resources.sound_off;
            soundEnabled = false;

            repulsion.Stop();
        }

        private void playSound(string wth2play = "")
        {

            if (soundEnabled)
            {
                var player = new MediaPlayer();

                switch (wth2play)
                {
                    // Столкновение с границами игры 
                    case "colision":
                        player.Open(new Uri("Sounds/clap.wav", UriKind.Relative));
                        break;
                    // Столкновение с ускоряющим объектом
                    case "myObjClassBoost":
                        player.Open(new Uri("Sounds/booster.wav", UriKind.Relative));
                        break;
                    // Звук когда заканчивается игра
                    case "finishGame":
                        player.Open(new Uri("Sounds/gameover.wav", UriKind.Relative));
                        break;
                    // Звук когда отловленный объект встречается с воскрешающим объектом
                    case "resurection":
                        player.Open(new Uri("Sounds/resurect.wav", UriKind.Relative));
                        break;
                    // Звук когда нажимают на паузу
                    case "pause":
                        player.Open(new Uri("Sounds/pause.wav", UriKind.Relative));
                        break;
                    // Звук когда пользователь стакивается с отлавливаемым объектом
                    case "getQuestion":
                        player.Open(new Uri("Sounds/question.wav", UriKind.Relative));
                    break;
                    case "levelChanges":
                        player.Open(new Uri("Sounds/levelchanged.wav", UriKind.Relative));
                    break;
                }

                player.Play();
            }
        }

        private string borderDetect(int objHeight, int objWidth, int objX, int objY, string objDirection)
        {
            bool p = false;

            // Функция проверяет, не столкнулись ли предметы с границами

            if ((ClientSize.Height - objHeight) <= objY)
            { objDirection = "up"; p = true; }
            else if (24 > objY)
            { objDirection = "down"; p = true; }
            else if ((ClientSize.Width - objHeight) <= objX)
            { objDirection = "left"; p = true;}
            else if (0 > objX)
            { objDirection = "right"; p = true; }

            if (p) { playSound("colision"); }

            return objDirection;
        }

        private bool clashDetect(Rectangle obj1, Rectangle obj2)
        {
            bool clash = false;

            // проверка столкновения по вертикали и горизонтали - пользователя и объектов для отлова
            int sumL = obj1.Width / 2 + obj2.Width / 2;
            int distanceL = Math.Abs((obj2.X + obj2.Width / 2) - (obj1.X + obj1.Width / 2));

            int sumT = obj1.Height / 2 + obj2.Height / 2;
            int distanceT = Math.Abs((obj2.Location.Y + obj2.Height / 2) - (obj1.Y + obj1.Height / 2));

            if (distanceL < sumL && distanceT < sumT) { clash = true; }

            return clash; 
        }

        private string changeDirection(string var = "", bool useRandom = false)
        {
            if (useRandom)
            {
                switch (rand.Next(1, 5))
                {
                    case 1: var = "left"; break;
                    case 2: var = "right"; break;
                    case 3: var = "up"; break;
                    case 4: var = "down"; break;
                }
            }
            else
            {
                switch (var)
                {
                    case "up": var = "down"; break;
                    case "down": var = "up"; break;
                    case "left": var = "right"; break;
                    case "right": var = "left"; break;
                }
            }

            return var;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up: direction = "up"; break;
                case Keys.Left: direction = "left"; break;
                case Keys.Down: direction = "down"; break;
                case Keys.Right: direction = "right"; break;
                case Keys.Space: direction = ""; break;
                case Keys.Escape:
                    if (MessageBox.Show("Выйти из игры", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { this.Close(); }   
                break;
                case Keys.Enter:
                    if (pause == true && infoPanel.Enabled == false)
                    {
                        playSound("pause");
                        infoPanel.BackgroundImage = Properties.Resources.pause;
                        startStopGame(false);
                        pause = false;

                        label1_info.Enabled = false;
                    }
                    else if (pause == false && infoPanel.Enabled == false)
                    {
                        infoPanel.BackgroundImage = null;
                        startStopGame(true);
                        pause = true;

                        label1_info.Enabled = true;
                    }
                    break;
            }
        }

        private void Game1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dontUseAutomaticMoving)
                direction = "";
        }

        private void movePicture()
        {
            if (pictureMove)
            {
                switch(direction)
                {
                    case "up": ba++; break;
                    case "down": ba--; break;
                    case "left": ab++; break;
                    case "right": ab--; break;
                }
            } 
            else
            {
                ab = -200;
                ba = -200;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int u = 0;
            // Проверяем количество уже отловленных объектов
            for (int i = 0; i < cObj; i++) { if (catched[i] == true) u++; }
            // Если количество отловленных объектов исчерпано заканчиваем игру
            if (u >= cObj)
            {
                if (goodScore < badScore)
                {
                    playGame = false;
                }
                else
                {
                    level++;
                    levelChoise();
                }
            }

            if (cObj > maxColObj) playGame = false;


            // Если игра началась или нет-проигрыша, то разрешаем двигать предмет
            if (playGame == true)
            {
                
                // Если скорость превышает определенное значение, збрасываем
                if (catchObjspeed == 25 && endBoost)
                    catchObjspeed = mainObjSpeed;

                // указывает двигать картинку или нет
                movePicture();

                // ------------- Управляемый объект -------------------- // 
                g.DrawImage(BgObj, new Point(ab, ba));

                genImpactObjs(false); //++++++++++++++++++++++++++++++++++++++++++++++++++++++

                // Если включен турбо кубик для возможности активации турбо режима
                // то выводим соответсвующий куб
                // и проверяем столкновение, если оно произошло включаем турбо режим

                // Если превыщенно время ожидания отключаем турбо
                if (tempBoost >= tBoostTime)
                {
                    tempBoost = 0;
                    usetboost = false;
                }else{
                    // Столкновение с объектом который дает ускорение объекту пользователя 
                    if (oddEven == true)
                    {
                        bomb_Obj.X = 0;
                        bomb_Obj.Y = 0;
                        g.DrawImage(tbObj_g, tb_Obj.X, tb_Obj.Y, tb_Obj.Width, tb_Obj.Height);
                    }
                    else
                    {
                        tb_Obj.X = 0;
                        tb_Obj.Y = 0;
                        g.DrawImage(obj_bomb, bomb_Obj.X, bomb_Obj.Y, bomb_Obj.Width, bomb_Obj.Height);
                    }

                    // Проверяем, если объект пользователя столкнулся с объектом для ускорения устанавливаем ускорение
                    // Если пользовательский объект столкнулся с объектом бомбочка то даем ему рандомные координаты

                    if (clashDetect(tb_Obj, mv_Obj))
                    {
                        genRandObjPlace();
                        usetboost = true;
                        playSound("myObjClassBoost");
                    }
                    else if (clashDetect(bomb_Obj, mv_Obj))
                    {
                        genRandObjPlace();

                        mv_Obj.X = rand.Next(1, winHoriSize);
                        mv_Obj.Y = rand.Next(1, winVertSize);
                    }

                }

                // проверяем столкновение объекта пользователя ------
                direction = borderDetect(mMenu.Height, mMenu.Width, mv_Obj.X, mv_Obj.Y, direction);

                // Если используется ускорение, то увеличиваем шаг пользовательского объекта
                int b = 1;

                if (usetboost == true)
                { tempBoost++; b = catchObjspeed + boostObjspeed+5; }
                else
                { b = catchObjspeed+5; }

                // Перемещаем предмет пользователя по указанному пути 
                switch (direction)
                {
                    case "up": mv_Obj.Y -= b; break;
                    case "left": mv_Obj.X -= b; break;
                    case "down": mv_Obj.Y += b; break;
                    case "right": mv_Obj.X += b; break;
                }

                // -----------------------------------------
                //      Проверяем все объекты для отлова
                // ----------------------------------------- 

                for (int i = 0; i < cObj; i++)
                {
                    // ИСПОЛЬЗУЕТСЯ ДЛЯ ИЗМЕНЕНИЕ ТРАЕКТОРИИ ДВИЖЕНИЯ ОБЪЕКТА
                    if (step == maxStep)
                    {
                        // При новом шаге всем объектам указываем новое направление
                        for (int j = 0; j < cObj; j++)
                        {
                            colDirs[i] = changeDirection(colDirs[i], true);
                        }
                    }

                    // Если вражеский объект взял бомбу

                    if (clashDetect(bomb_Obj, arrayColObj[i]))
                    {
                        genRandObjPlace();

                        mv_Obj.X = rand.Next(1, winHoriSize);
                        mv_Obj.Y = rand.Next(1, winVertSize);

                    }

                    // CТОЛКНОВЕНИЕ ПОЛЬЗОВАТЕЛЯ С НЕОТЛОВЛЕННЫМИ ОБЪЕКТАМИ 

                    if (catched[i] == false)
                    {
                        // Проверяем столкновения отлавливаемых и пользователя объектов

                        if (clashDetect(arrayColObj[i], mv_Obj))
                        {
                            colDirs[i] = changeDirection(colDirs[i]);
                            //direction = changeDirection(direction);

                            if (useQuestions == true)
                                getQuestion = true;
                            else
                                goodScore++;

                            catched[i] = true;
                        }
                    }

                    // Воскрешаюшие с воскрешаюшими

                    // СТОЛКНОВЕНИЕ ОТЛАВЛИВАЕМЫХ ОБЪЕКТОВ С ВОСКРЕШАЮШИМИ ОБЪЕКТАМИ

                    for (int j = 0; j < rObj; j++)
                    {
                        // Если объект столкнулся с воскрешающим кубиком объектом, то возвращаем его в игру!
                        if (clashDetect(resurectObj[j], arrayColObj[i]))
                        {
                            // меняет направление при любом столкновениии !!!

                            // ------ поменять направление воскрешаемого объекта ---

                            resDirs[j] = changeDirection(resDirs[j]);
                            colDirs[i] = changeDirection(colDirs[i]);

                            if (useQuestions == false)
                            {
                                if (catched[i] == true) badScore++;
                            }
                            else
                            {
                                // Усложнение после указанного раунда, если объекты отловленный и воскрешающий встретятся то отнимаем очко у пользователя
                                if (level > 5 && goodScore > 0) goodScore--;
                            }

                            playSound("resurection");
                            catched[i] = false;
                        }

                        for (int y = 0; y < impactObj; y++)
                        {
                            if (clashDetect(im_obj[y], resurectObj[j]))
                            {
                                resDirs[j] = changeDirection(resDirs[j]);
                            }

                        }
                    }

                    // Проверка на столкновение с границей отлавливаемых объектов
                    colDirs[i] = borderDetect(mMenu.Height, mMenu.Width, arrayColObj[i].X, arrayColObj[i].Y, colDirs[i]);

                    switch (colDirs[i])
                    {
                        case "up": arrayColObj[i].Y -= catchObjspeed; break;
                        case "left": arrayColObj[i].X -= catchObjspeed; break;
                        case "down": arrayColObj[i].Y += catchObjspeed; break;
                        case "right": arrayColObj[i].X += catchObjspeed; break;
                    }

                    // ------------------------------------------------------
                    // Проверка столкновения с "ландшафтными объектами"
                    // ------------------------------------------------------

                    for (int y = 0; y < impactObj; y++)
                    {
                        // проверяем столкновение пользователя
                        if (clashDetect(im_obj[y], mv_Obj))
                        {
                            playSound("myObjClassBoost");
                            direction = changeDirection(direction);

                        }

                        // проверяем столкновение отловленных объектов
                        if (clashDetect(im_obj[y], arrayColObj[i]))
                        {
                            colDirs[i] = changeDirection(colDirs[i], true);
                        } 
                    }

                    // Если объекты столкнулись и ответ был правильным, то окрашиваем кубик 
                    if (catched[i] == true)
                    {
                        switch (colDirs[i])
                        {
                            case "up": colisObj = Properties.Resources.catObj_top; break;
                            case "left": colisObj = Properties.Resources.catObj_left; break;
                            case "down": colisObj = Properties.Resources.catObj_bottom; break;
                            case "right": colisObj = Properties.Resources.catObj_right; break;
                        }
                    }
                    else
                    {
                        switch (colDirs[i])
                        {
                            case "up": colisObj = Properties.Resources.colObject_top; break;
                            case "left": colisObj = Properties.Resources.colObject_left; break;
                            case "down": colisObj = Properties.Resources.colObject_bottom; break;
                            case "right": colisObj = Properties.Resources.colObject_right; break;
                        }
                    }

                    g.DrawImage(colisObj, arrayColObj[i].X, arrayColObj[i].Y, arrayColObj[i].Width, arrayColObj[i].Height);
                }


                // ЧАСТЬ ОБЪЕКТА КОТОРАЯ ВОСКРЕШАЕТ ДРУГИЕ КУБИКИ В ИГРЕ -------------------
                for (int i = 0; i < rObj; i++)
                {
                    // проверяем столкновение объекта пользователя ------
                    resDirs[i] = borderDetect(mMenu.Height, mMenu.Width, resurectObj[i].X, resurectObj[i].Y, resDirs[i]);

                    if (step == maxStep)
                    {
                        // Указываем путь для объектов которые будут воскрешать объекты
                        for (int j = 0; j < rObj; j++) { resDirs[j] = changeDirection(resDirs[j], true); }
                        step = 0;
                    }


                    // Указываем картинку объекту и перемешаем его
                    switch (resDirs[i])
                    {
                        case "up":
                            resObj = Properties.Resources.resObj_top;
                            resurectObj[i].Y -= resurectObjspeed;
                            break;
                        case "left":
                            resObj = Properties.Resources.resObj_left;
                            resurectObj[i].X -= resurectObjspeed;
                            break;
                        case "down":
                            resObj = Properties.Resources.resObj_bottom;
                            resurectObj[i].Y += resurectObjspeed;
                            break;
                        case "right":
                            resObj = Properties.Resources.resObj_right;
                            resurectObj[i].X += resurectObjspeed;
                            break;
                    }
                    g.DrawImage(resObj, resurectObj[i].X, resurectObj[i].Y, resurectObj[i].Width, resurectObj[i].Height);
                }


                // Выводим кнопку ответа, если встретились два объекта
                if (getQuestion == true)
                {
                    playSound("getQuestion");
                    getQuestion = false;
                    genQuestionButton();
                }

                good.Text = Convert.ToString(goodScore);
                bad.Text = Convert.ToString(badScore);

                // прорисовываем движущийся объект

                switch (direction)
                {
                    case "up": mObj = Properties.Resources.mainObject_top; break;
                    case "left": mObj = Properties.Resources.mainObject_left; break;
                    case "down": mObj = Properties.Resources.mainObject_bottom; break;
                    case "right": mObj = Properties.Resources.mainObject_right; break;
                    default: mObj = Properties.Resources.mainObject; break;
                }

                g.DrawImage(mObj, mv_Obj.X, mv_Obj.Y, mv_Obj.Width, mv_Obj.Height);

                Rectangle reg = new Rectangle(0, 0, winHoriSize, winVertSize); // Заного устанавливаем размеры окна

                this.Invalidate(reg); // обновить область

                step++;
            }
            else gameover(); // выводим конец игры
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Выйти из игры", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { this.Close(); }
        }

        private void genQuestionButton()
        {

            infoPanel.BackgroundImage = null;
            showTincr = 0;
            showInfo.Enabled = false;

            label1_info.Enabled = false;

            // Генерируем число для массива вопросов
            qNum = rand.Next(0, QuestionAmount);

            startStopGame(false);

            infoPanel.Enabled = true;
            infoPanel.BackgroundImage = Properties.Resources.info;

            // Текст задаваемого вопроса и параметры объекта
            questView.Location = new Point(26, 20);

            questView.Width = 284;
            questView.Height = 47;
            questView.Text = questions[qNum];// qa.questions(qNum);//questions[qNum]; //
            questView.TextAlign = ContentAlignment.MiddleCenter;
            infoPanel.Controls.Add(questView);

            // Текстовое поле куда вписывается ответ и параметры объекта
            textAns.Location = new Point(19, 69);
            textAns.Width = 281;
            textAns.Height = 20;
            textAns.TextChanged += new EventHandler(TextCH);
            infoPanel.Controls.Add(textAns);

            // Кнопка для ответа на вопрос и его параметры
            ansBtn.Location = new Point(121, 95);
            ansBtn.Width = 102;
            ansBtn.Height = 43;
            ansBtn.Text = "Ответить";
            ansBtn.Enabled = false;
            ansBtn.Click += new EventHandler(genAnswerResult); // Запускается 3 раза почему?????
            infoPanel.Controls.Add(ansBtn);
        }

        private void TextCH(object sender, EventArgs e)
        {
            if (textAns.Text != "")
                ansBtn.Enabled = true;
            else
                ansBtn.Enabled = false;
        }

        private void genAnswerResult(object sender, EventArgs e)
        {
            string answer = textAns.Text.ToLower();

            infoPanel.Enabled = false;
            infoPanel.BackgroundImage = null;

            questView.Text = "";
            infoPanel.Controls.Remove(questView);

            textAns.Text = "";
            infoPanel.Controls.Remove(textAns);

            infoPanel.Controls.Remove(ansBtn);

            // Проверяем ответы на вопросы
            if (answer != "")
            {
                if (answer == answers[qNum].ToLower()){
                    goodScore++;
                }else{
                    badScore++;
                }

                label1_info.Enabled = true;

                startStopGame(true);
            }
        }

        private void showInfo_Tick(object sender, EventArgs e)
        {
            if (showTincr >= showTime)
            {
                startStopGame(true);
                infoPanel.BackgroundImage = null;
                showTincr = 0;
                showInfo.Enabled = false;
                sh = false;
            }
            else
            {
                startStopGame(false);

                if (!sh)
                {
                    sh = true;
                    switch (level)
                    {
                        case 1:
                            infoPanel.BackgroundImage = Properties.Resources._1round;
                            break;
                        case 2:
                            infoPanel.BackgroundImage = Properties.Resources._2round;
                            break;
                        case 3:
                            infoPanel.BackgroundImage = Properties.Resources._3round;
                            break;
                        case 4:
                            infoPanel.BackgroundImage = Properties.Resources._4round;
                            break;
                        case 5:
                            infoPanel.BackgroundImage = Properties.Resources._5round;
                            break;
                        case 6:
                            infoPanel.BackgroundImage = Properties.Resources._6round;
                            break;
                        case 7:
                            infoPanel.BackgroundImage = Properties.Resources._7round;
                            break;
                        case 8:
                            infoPanel.BackgroundImage = Properties.Resources._8round;
                            break;
                        case 9:
                            infoPanel.BackgroundImage = Properties.Resources._9round;
                            break;
                        case 10:
                            infoPanel.BackgroundImage = Properties.Resources._10round;
                            break;
                        case 11:
                            infoPanel.BackgroundImage = Properties.Resources._11round;
                            break;
                        case 12:
                            infoPanel.BackgroundImage = Properties.Resources._12round;
                            break;
                    }
                }
                showTincr++;
            }
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string data = "Автор:\t\t Максим Шмыков,\nГруппа: \t\t 2KTVR\nУч.Учреждение: \t http://www.ivkhk.ee";

            if (MessageBox.Show(data, "Об авторе", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                // Пауза игры !!!!
            }
             
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (label1_info.Enabled == true)
            {
                // Выводит или скрывает инфо меню. Правила игры 
                if (show)
                {
                    infoPanel.Enabled = false;
                    infoPanel.BackgroundImage = null;
                    show = false;
                    startStopGame(true);
                }
                else
                {
                    infoPanel.Enabled = true;
                    infoPanel.BackgroundImage = Properties.Resources.howto;
                    show = true;
                    startStopGame(false);
                }
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            //Hide(); Show(); Close();

            settingsForm f = new settingsForm();
            f.ShowDialog();
            f.Close();
           
        }

        private void startStopGame(bool enabledGame = false)
        {

            if (enabledGame == true)
            {
                playGame = true;

                t_mvObj.Enabled = true;
                t_Count.Enabled = true;

                // Удаляем все объекты вне зависимости есть они или нет
                infoPanel.Controls.Remove(repeat);
                infoPanel.Controls.Remove(lblres);

                questView.Text = "";
                infoPanel.Controls.Remove(questView);

                textAns.Text = "";
                infoPanel.Controls.Remove(textAns);

                infoPanel.Controls.Remove(ansBtn);

                infoPanel.Enabled = false;
            }
            else
            {
                t_mvObj.Enabled = false;
                t_Count.Enabled = false;
                playGame = false;
            }
        }

        private void gameover()
        {
            /* сбрасываем все настройки */

            repulsion.Stop();

            genImpactObjs(false);
            playSound("finishGame");
            startStopGame(false);

            soundlbl.Enabled = false;
            counter.Text = "";
            lvlbl.Image = null;
            good.Image = null;
            bad.Image = null;
            label1_info.Image = null;
            label1_info.Enabled = false;
            label1_info.Text = "";
            soundlbl.Image = null;

            infoPanel.BackgroundImage = Properties.Resources.gameover1;
            g.DrawImage(BgObj, new Point(0, 0));

            Rectangle reg = new Rectangle(0, 0, winHoriSize, winVertSize); // Заного устанавливаем размеры окна

            this.Invalidate(reg); // обновить область

            /*
            cObj = maincObj;

            arrayColObj = new Rectangle[cObj];
            catched = new bool[cObj];
            colDirs = new string[cObj];

            fixTextures(arrayColObj, im_obj, cObj);

            */
            catchObjspeed = mainObjSpeed;

            settings.Enabled = true;
            lvlbl.Text = Convert.ToString("");

            direction = "";

            questView.Text = "";
            infoPanel.Controls.Remove(questView);

            textAns.Text = "";
            infoPanel.Controls.Remove(textAns);

            infoPanel.Controls.Remove(ansBtn);

            good.Text = "";
            bad.Text = "";

            // Отключаем игру ----------------------
            gameBegin.Enabled = true;
            endGame.Enabled = false;

            infoPanel.Enabled = true;
            infoPanel.BackColor = System.Drawing.Color.Transparent;//System.Drawing.Color.Azure;  //Color.Transparent;


            lblres.Location = new Point(26, 20);
            lblres.TextAlign = ContentAlignment.MiddleCenter;
            lblres.AutoSize = false;
            lblres.Height = 47;
            lblres.Width = 284;

            finalResultGood = finalResultGood + goodScore;
            finalResultBad = finalResultBad + badScore;


            if (finalResultGood > finalResultBad)
            {
                lblres.Text = "Вы выиграли. Счет " + Convert.ToString(finalResultGood) + ":" + Convert.ToString(finalResultBad) + " Ваш уровень: " + level;
            }
            else if (finalResultGood == finalResultBad)
            {
                lblres.Text = "У вас ничья " + Convert.ToString(finalResultGood) + ":" + Convert.ToString(finalResultBad) + " Ваш уровень: " + level;
            }
            else
            {
                lblres.Text = "Вы проиграли. Счет " + Convert.ToString(finalResultGood) + ":" + Convert.ToString(finalResultBad) + " Ваш уровень: " + level;
            }

            level = 1;

            infoPanel.Controls.Add(lblres);

        }

        private void endGame_Click(object sender, EventArgs e) {
            gameover();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Выйти из игры", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { this.Close(); }
        }

        public static bool showErrorMsg = false;

        private void getQuestions()
        {
            string pathQuestions = @"Resources\Questions.txt";
            string pathAnswers = @"Resources\Questions.txt";

            string msg = "";

            if (!System.IO.File.Exists(pathQuestions) || !System.IO.File.Exists(pathAnswers))
            {
                showErrorMsg = true;

                msg = "Файлы с вопросами и ответами не найдены!\n\n Вопросы будут отключенны!\n\n";
                msg += "Для добавления вопросов вам необходимо создать папку Resources в папке с игрой, а в ней два файла\n";
                msg += "Файл Questions.txt с вопросами внутри и Answers.txt с ответами внутри";
            }
            else
            {
                // вытаскиваем все вопросы и ответы
                string[] qstns = System.IO.File.ReadAllLines(@"Resources\Questions.txt");
                string[] answrs = System.IO.File.ReadAllLines(@"Resources\Answers.txt");

                int Q = qstns.Length;
                int A = answrs.Length;

                if (Q > 0 && A > 0)
                {
                    if (Q == A)
                    {
                        QuestionAmount = qstns.Count();

                        questions = new string[qstns.Count()];
                        answers = new string[qstns.Count()];

                        for (int i = 0; i < qstns.Length; i++)
                        {
                            questions[i] = qstns[i];
                            answers[i] = answrs[i];
                        }
                    }
                    else
                    {
                        msg = "Ошибка! Кол-во ответов и вопросов, не совпадают.\nВ файле, в массиве у вас ответов: " + A.ToString() + " и вопросов: " + Q.ToString() + "\n\nВопросы отключенны!" + "\n\nДля добавления вопросов или ответов вы должны зайти в папку Resources рядом с игрой и отредактировать нужные файлы!";
                        showErrorMsg = true;
                    }
                }
                else
                {
                    msg = "Вопросы или ответы не найдены! Вы играете без вопросов...";
                    showErrorMsg = true;
                }
            }

            if (showErrorMsg)
            {
                MessageBox.Show(msg, "Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                useQuestions = false;
            }
        }

        //Global variables;
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;

            this.Opacity = 1.0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
                this.Opacity = 0.7;
            }
        }

    }
}
