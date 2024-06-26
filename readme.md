Windows Forms Project by:Kostadin Pejoski with index number 226088 and Jovan Davaliev with index number 226035
---
1. Опис на апликацијата Апликацијата што ја развиваме е класичната игра Quiz for Million Dollars.Во нашата верзија на апликацијата освен одговaрањето на прашањата исто така ги имаме имплементирано и опциите повикај пријател,50:50 и прашај ја публиката.Нашата инспирација за оваа игра ја добивме од телевизиската емисија Who Wants To Be A Milionaire.Нашата игра овозможува регистирирање на играчот со неговото име и презиме и бирање на категорија на која тој би сакал да одговара.Нашата апликација ги нуди следните категории:спорт,музика,технологија и географија.Секоја категорија се состои од 12 парашања за кои важи дека секое наредно парашање е потешко од претходното.

2. Упатство за користењe
Слика 1
![pocetok na igra](https://github.com/Hekaton003/VP-proektna-zadaca/assets/94937416/aa75efda-4343-49dd-ae49-249420054d9b)

2.1 Нова игра
   На почетниот прозорец (слика 1) при стартување на апликцијата имаме две можности односно да ја започнеме играта (Start Game) или да ги видиме правилата на играта(Game Rules).

 Слика 2
![vnesuvanje na ime i prezime](https://github.com/Hekaton003/VP-proektna-zadaca/assets/94937416/5dbd4441-b1e7-41e3-b513-60ba0fbca02f)

2.2 Доколку кликнеме на (Start Game) се отвара прозорец како на слика 2.Во тој прозорец имаме еден едно ок копче  и еден textbox во кои играчот треба да го внеси своето име и презиме.Доколку играчот го остави тој textbox празен тогаш играта нема да започне и ќе се вратиме на почеток односно слика 1.

2.3 Правила на играта:
   Почеток на играта:

 1. Учесници: Оваа игра е наменета за еден играч кои треба да одговори 12 прашања од категорија која тој сам ќе ја избери.

 2. Структура на прашања: Постојат 12 прашања за секоја категорија со 1 точен одговор од 4 понудени A,B,C,D.

 3. Систем на наградување: Секое прашање носи повисока парична награда која го достигнува врвот со дванаесетото прашање кое носи награда од милион долари


 4. Бирање на категорија: Играчот ја бира категоријата на која сака да одговара и играта започнува со најлесното прашање кое носи најмала парична награда.

 5. Прогресија: Прашањата стануваат прогресивно потешки како што натпреварувачот ја игра играта.

 6. Одговарање на прашањата: Играчот избира еден од понудените одговори.Тој мора да го потврди својот одговор пред да биде проверен дали е точен или не.
 
 7. Играчот можи да искористи помош на 3 начини во секој момент од играта.Секој начин може да се искористи само еднаш

       Повикај пријател: Играчот може да побара помош од еден од 3 можни пријатели.Пријателот дава мислење за тоа кој е можен точен одговор.

       Прашај ја публиката: Играчот може да побара помош од публиакта.Секој во публиката дава свое мислење за кој е точниот одговор.Резултати се прикажани графички односно колкав % од публиката гласала за секој одговор.

       50:50:Играчот може да го преполови бројот на понудени одговори односно од 4 да бидат 2 понудени одговори па така да си ги зголеми шансите за погодок.
       
 8. излез од играта: Играчот во секој момент од квизот може да одлучи да го напушти квизот и со себе да ја земи наградата од претходното точно прашање.
         
 9. Неточни одговори 

      Доколку играчот одговори неточно на дадено прашање тогаш играта завршува и тој како награда ја добива сумата која ја носи последно точно одговореното прашање. 

 10. Дополнителни правила:

    Временски Ограничувања: Постои временско ограничување од 6 минути за одговарање на сите прашање со цел да се додаде притисок и возбуда.


   Слика 3
    ![main od igrata](https://github.com/Hekaton003/VP-proektna-zadaca/assets/94937416/817774ba-a372-4cd4-8ab3-1c7563b85a79)

3. Претставување на проблемот

Нас играта ни се изведува преку 2 главни класи:Question и Game.

Класа: Question
```
  public class Question
  {
      public string TheQuestion {  get; set; }
      public string CorrectAnswer { get; set; }
      public List<string> Answers { get; set; }
      public bool Answered { get; set; }

      public Question(string theQuestion, string correctAnswer, List<string> answers)
      {
          TheQuestion = theQuestion;
          CorrectAnswer = correctAnswer;
          Answers = answers;
          Answered = false;
      }
  }
```

Question е класа која претставува прашање од квиз играта. Таа содржи неколку променливи и еден конструктор.

Променливи

    TheQuestion
        Ова својство ги зачувува текстот на прашањето.
    CorrectAnswer
        Ова својство го зачувува точниот одговор на прашањето.
    Answers
        Ова својство содржи листа со сите можни одговори за прашањето.
    Answered
        Ова својство означува дали прашањето е одговорено или не.
        Првично е поставено на false во конструкторот, што значи дека прашањето не е одговорено на почетокот.

Конструkтор

Question(string theQuestion, string correctAnswer, List<string> answers)
    Овој конструктор се користи за иницијализација на објект од класата Question со специфични вредности.
    Параметри:
        theQuestion: текстот на прашањет
        correctAnswer: точниот одговор на прашањето.
        answers: листа со можни одговори за прашањето.
    Во телото на конструкторот, својствата се иницијализираат со вредностите на пар

Класа:Game

```
 public class Game
 {
     public string PlayerName { set; get; }
     public string Category { set; get; }
     public int Money { set; get; } = 0;
     public int CurrentQuestionIndex { set; get; } = -1;

     public bool HasStarted { set; get; }=false;
     public List<Question> CurrentQuestions {  set; get; }
     public static List<Question> SportQuestions  = new List<Question>();
     public static List<Question> TechnologyQuestions = new List<Question>();
     public static List<Question> MusicQuestions = new List<Question>();
     public static List<Question> GeographyQuestions = new List<Question>();

     public static void loadQuestions()
     {
         //sportski prasanja
         SportQuestions.Add(new Question(
             "1.What sport is best known as the ‘king of sports’?",
             "Football", 
             new List<string> { "Basketball", "Football", "Baseball", "Volleyball" }));
         SportQuestions.Add(new Question(
             "2.What country has competed the most times in the Summer Olympics yet hasn’t won a gold medal?",
             "Philippines",
             new List<string> { "USA", "Philippines", "Japan", "Brazil" }));
         SportQuestions.Add(new Question(
             "3.Which boxer fought against Muhammad Ali and won?",
             "Joe Frazier",
             new List<string> { "Joe Frazier", "Sugar Ray Robinson", "Mike Tyson", "George Foreman" }));
         SportQuestions.Add(new Question(
             "4.What type of race is the Tour de France?",
             "Bicycle race",
             new List<string> { "Bicycle race", "Motorcycle race", "Formula race", "Auto race" }));
         SportQuestions.Add(new Question(
             "5.How many sports were included in the 2008 Summer Olympics?",
             "28",
             new List<string> { "34", "20", "28", "39" }));
         SportQuestions.Add(new Question(
             "6.In which winter sport are the terms “stale fish” and “mule kick” used?",
             "Snowboarding",
             new List<string> { "Ice hockey", "Snowboarding", "Ski jumping", "Bobsleigh" }));
         SportQuestions.Add(new Question(
             "7.What is the only team in the NFL to neither host nor play in the Super Bowl?",
             "Cleveland Browns",
             new List<string> { "Cleveland Browns", "Arizona Cardinals", "Chicago Bears", "Houston Texans" }));
         SportQuestions.Add(new Question(
             "8.Which basketball player was Michael Jordan nicknamed after when he was in high school?",
             "Magic Johnson",
             new List<string> { "Magic Johnson", "Michael Adams", "Mike Miller", "Michael Beasley" }));
         SportQuestions.Add(new Question(
             "9.Who was the youngest player to score 10,000 points in the NBA?",
             "LeBron James",
             new List<string> { "Stephen Curry", "LeBron James", "Michael Jordan", "Kobe Bryant" }));
         SportQuestions.Add(new Question(
             "10.What African country was the first ever to qualify for a World Cup?",
             "Egypt",
             new List<string> { "Morocco", "Tunis", "Congo", "Egypt" }));
         SportQuestions.Add(new Question(
             "11.What team won the very first NBA game in 1946?",
             "New York Knicks",
             new List<string> { "Boston Celtics", "Washington DC", "New York Knicks", "Denver Nuggets" }));
             SportQuestions.Add(new Question(
             "12.Who was the first woman to climb Mt. Everest?",
             "Junko Tabei",
             new List<string> { "Junko Tabei", "Marcia Frederick", "Marit Bjørgen", "Kathy Whitworth" }));
        
         //muzicki prasanja

         MusicQuestions.Add(new Question(
             "1.What was Freddie Mercury's real name?",
             "Farrokh Bulsara",
             new List<string> { "Farrokh Bulsara", "Bomi Bulsara", "Ketan Ramanlal Bulsara", "Barry Bulsara" }));
         MusicQuestions.Add(new Question(
             "2.What pop star wrote songs for Ariana Grande, Miley Cyrus, Britney Spears and Alice Cooper?",
             "Kesha",
             new List<string> { "Beyonce", "Dua Lipa", "Kesha", "Rihanna" }));

         MusicQuestions.Add(new Question(
             "3.Before Miley Cyrus recorded 'Wrecking Ball,' it was offered to which singer?",
             "Beyonce",
             new List<string> { "Beyonce", "Ariana Grande", "Rihanna", "Alice Cooper" }));

         MusicQuestions.Add(new Question(
             "4.What was Elvis Presley's first No. 1 hit in the United States?",
             "Heartbreak Hotel",
             new List<string> { "Jailhouse Rock", "Heartbreak Hotel", "Suspicious Minds", "An American Trilogy" }));


         MusicQuestions.Add(new Question(
            "5.Where was Tupac Shakur born?",
             "East Harlem, New York",
             new List<string> { "Chelsea, New York", "East Harlem, New York", "Jamaica, New York", "Brooklyn Heights, New York" }));
 
         MusicQuestions.Add(new Question(
             "6.How many coaches (full and part-time) from The Voice have won Grammys?",
             "12",
             new List<string> { "15", "10", "12", "6" }));

         MusicQuestions.Add(new Question(
             "7.What is Michael Jackson's biggest hit?",
             "Billie Jean",
             new List<string> { "Rock With You", "Billie Jean", "The Way You Make Me Feel", "Black or White" }));

         MusicQuestions.Add(new Question(
             "8.Which Marvel movie's soundtrack won two Grammys?",
             "Black Panther",
             new List<string> { "Captain America", "Avengers", "Iron Man", "Black Panther" }));
         
         MusicQuestions.Add(new Question(
             "9.What is the real name of the rapper known as Snoop Dogg?",
             "Calvin Cordozar Broadus Jr.",
             new List<string> { "Calvin Cordozar Broadus Jr.", "Vernell Varnado", "Daz Dillinger", "Nate Dogg" }));
         
         MusicQuestions.Add(new Question(
             "10.Which city is often referred to as the birthplace of jazz?",
             "New Orleans",
             new List<string> { "San Francisco", "New Orleans", "Miami", "Chicago" }));

         MusicQuestions.Add(new Question(
             "11.What is the name of the lead singer of the band Aerosmith?",
             "Steven Tyler",
              new List<string> { "Steven Tyler", "Tom Hamilton", "Joey Kramer", "Joe Perry" }));

         MusicQuestions.Add(new Question(
              "12.Who is often referred to as the 'Queen of Pop'?",
              "Madonna",
               new List<string> { "Beyonce", "Whitney Houston", "Taylor Swift", "Ma
         //geografski prasanja
                 GeographyQuestions.Add(new Question(
        "1.Which country has the second largest population in the world?",
        "China",
        new List<string> { "China", "USA", "Brazil", "Russia" }));

        GeographyQuestions.Add(new Question(
        "2.What is the name of the third longest river in Africa?",
        "Niger river",
        new List<string> { "Nile river", "Niger river", "Congo river", "Kasai river" }));


        GeographyQuestions.Add(new Question(
        "3.What U.S. state is home to no documented poisonous snakes?",
        "Alaska",
        new List<string> { "Florida", "Hawaii", "California", "Alaska" }));


        GeographyQuestions.Add(new Question(
        "4.What present-day Italian city does Mt. Vesuvius overlook?",
        "Naples, Italy",
        new List<string> { "Naples, Italy", "Rome, Italy", "Palermo, Italy", "Salerno, Italy" }));


        GeographyQuestions.Add(new Question(
        "5.What country has the most natural lakes?",
        "Canada",
        new List<string> { "USA", "Finland", "Canada", "Russia" }));


        GeographyQuestions.Add(new Question(
        "6.Where are the Spanish Steps located?",
        "Rome, Italy",
        new List<string> { "Madrid, Spain", "Valencia, Spain", "Marseille, France", "Rome, Italy" }));

        GeographyQuestions.Add(new Question(
        "7.What is the name of the largest city in Australia?",
        "Sydney",
        new List<string> { "Sydney", "Melbourne", "Brisbane", "Perth" }));

        GeographyQuestions.Add(new Question(
        "8.What is the name of the driest continent on Earth?",
        "Antarctica",
        new List<string> { "Antarctica", "South America", "Asia", "Africa" }));

        GeographyQuestions.Add(new Question(
        "9.What country is known to have the best quality tap water?",
        "Switzerland",
        new List<string> { "Germany", "France", "Switzerland", "Sweden" }));

        GeographyQuestions.Add(new Question(
        "10.What city is known as the Glass Capital of the World?",
        "Toledo",
        new List<string> { "San Francisco", "Toronto", "Tokyo", "Toledo" }));

        GeographyQuestions.Add(new Question(
        "11.What is the name of the deepest point in Earth’s oceans?",
        "Mariana’s Trench",
        new List<string> { "Mariana’s Trench", "Kermadec trench", "Kuril-Kamchatka trench", "Puerto Rico trench" }));

        GeographyQuestions.Add(new Question(
        "12.How many countries are there in Africa?",
        "54",
        new List<string> { "45", "54", "64", "78" }));


        //prasanja za tehnologija

        TechnologyQuestions.Add(new Question(
        "1.What was the most downloaded app of the 2010s?",
        "Facebook",
        new List<string> { "Facebook", "Instagram", "Youtube", "Twitter" }));

        TechnologyQuestions.Add(new Question(
        "2.What programming language is named after a type of Indonesian coffee?",
        "Java",
        new List<string> { "Java", "JavaScript", "Pascal", "Fortran" }));


        TechnologyQuestions.Add(new Question(
        "3.In what year did the first Amazon Web Service launch to the public?",
        "2004",
        new List<string> { "2000", "2005", "1994", "2004" }));

        TechnologyQuestions.Add(new Question(
        "4.What was the first home gaming console called?",
        "Magnavox Odyssey",
        new List<string> { "Nitendo", "Sony Playstation 2", "Magnavox Odyssey", "Microsoft Xbox" }));

        TechnologyQuestions.Add(new Question(
        "5.In what year was the first airplane invented?",
        "1903",
        new List<string> { "1900", "1903", "1895", "1910" }));

        TechnologyQuestions.Add(new Question(
        "6.What company employs the largest number of language translators?",
        "Google",
        new List<string> { "Amazon", "Google", "Microsoft", "Apple" }));


        TechnologyQuestions.Add(new Question(
        "7.In what year did Apple introduce the standard lightning cable?",
        "2012",
        new List<string> { "2012", "2010", "2014", "2015" }));

        TechnologyQuestions.Add(new Question(
        "8.Who invented the first Fighter Jet?",
        "Hans von Ohain",
        new List<string> { "Frank Whittle", "Hans von Ohain", "Wernher von Braun", "Kelly Johnson" }));

        TechnologyQuestions.Add(new Question(
        "9.What country has the largest market of gamers?",
        "China",
        new List<string> { "China", "USA", "Great Britain", "Canada" }));

        TechnologyQuestions.Add(new Question(
        "10.In what year was eBay founded?",
        "1995",
        new List<string> { "1999", "1995", "1985", "2000" }));

        TechnologyQuestions.Add(new Question(
        "11.What is the name for a computer virus which replicates itself and uses up all a computer’s processing space?",
        "Worm",
        new List<string> { "Trojan Horses", "Worm", "Resident Virus", "Polymorphic Virus" }));

        TechnologyQuestions.Add(new Question(
        "12.What British computer scientist is widely credited with inventing the World Wide Web?",
        "Tim Berners-Lee",
        new List<string> { "Tim Berners-Lee", "Robert Cailliau", "Gordon Brown", "Roger Wicker" }));

    }

    public void loadAllQuestions(string v)
    {
        if (v.Equals("Sport"))
        {
            CurrentQuestions = SportQuestions;
        }
        else if (v.Equals("Technology"))
        {
            CurrentQuestions= TechnologyQuestions;
        }
        else if (v.Equals("Music"))
        {
            CurrentQuestions= MusicQuestions;
        }
        else
        {
            CurrentQuestions = GeographyQuestions;
        }
    }
    public bool CheckAnswer(string option)
    {
        Question question = CurrentQuestions[CurrentQuestionIndex];
        if (question == null)
        {
            return false;
        }
        if (option == "A")
        {
            string answer = question.Answers[0];
            if(answer == question.CorrectAnswer)
                    return true;
            else return false;
          
        }else if(option == "B")
        {
            string answer = question.Answers[1];
            if (answer == question.CorrectAnswer)
                 return true;
            else return false;
            
        }
        else if (option == "C")
        {
            string answer = question.Answers[2];
            if (answer == question.CorrectAnswer)
                return true;
            else return false;
        }
        else if(option == "D")
        {
            string answer = question.Answers[3];
            if (answer == question.CorrectAnswer)
                return true;
            else return false;
        }
        else
        {
            return false;
        }
    }
}
```
Во оваа класа се води главанта логика на играта
Оваа класа има неколку својства неколку функции на инстанца една статичка функција неколку променливи на ниво на инстанца и неколку статички листи.
Во оваа класа ги има следните функционалности:

Започнување на играта односно откако ќе се избери категорија да се поставуваат прашања од соодветната категорија.

Промена на прашање односно доколку едно парашање е точно одговорено соодветно да се постави наредното.

Проверка на даден одговор односно за моментално поставеното прашање се проверува дали дадедниот одговор се совпаѓа со променливата CorrectAnswer од објектот од моменталното прашање.

Опишување на функција од изворниот код:

```
public bool CheckAnswer(string option)
{
    Question question = CurrentQuestions[CurrentQuestionIndex];
    if (question == null)
    {
        return false;
    }
    if (option == "A")
    {
        string answer = question.Answers[0];
        if(answer == question.CorrectAnswer)
                return true;
        else return false;
      
    }else if(option == "B")
    {
        string answer = question.Answers[1];
        if (answer == question.CorrectAnswer)
             return true;
        else return false;
        
    }
    else if (option == "C")
    {
        string answer = question.Answers[2];
        if (answer == question.CorrectAnswer)
            return true;
        else return false;
    }
    else if(option == "D")
    {
        string answer = question.Answers[3];
        if (answer == question.CorrectAnswer)
            return true;
        else return false;
    }
    else
    {
        return false;
    }
```

Оваа функција се наоѓа во класата Game.Оваа функција е public и тоа значи дека може да биде пристапена од надвор.Тоа е посакувано однесување бидејќи сакаме да знаеме дали дадениот одговор е точен за моменталното прашање.Функцијата прима еден аргумент option од тип string односно тоа ни ја претставува која опција ја избрал играчот за моменталното прашање односно A,B,C или D.Се зема инстанца од моменталното прашање односно од прашањата од категоријата која ја избрал играчот се зема прашањето на позиција CurrentQuestionIndex.Бидејќи ова е public променлива таа содветно била ажурирана да има вредност на индексот на поставеното прашање.Потоа се проверува  параметарот option и се споредува дали од понудените одговори за даденото прашање односно доколку option има вредност А се проверува првиот понуден одговор дали е еднаков со точниот одговор и доколку да функцијата враќа вредност true во спротивно false.Аналогно важи и за другите можни вредности на параметарот option.
