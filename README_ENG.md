# FinkiFeud

FinkiFued is a quiz game inspired from the American TV show called Family Feud with the difference that FinkiFeud is played by just one player and the round from Family Feud called Fast Money Round is replaced by a Maze Finale round. If you don't know of the TV show you can look at it in the links below and find more information:

* Video link: https://www.youtube.com/watch?v=2jepno7MDz8
* Wikipedia link: https://en.wikipedia.org/wiki/Family_Feud
* Original Website: https://www.familyfeud.com/

The point of the game is to earn as much points as possible and to pass both rounds as well as to be in a decent place in the top 10 highscores board.

# Description of the application:

At the start of the application a start menu opens where you can either start the game or exit the application.
![Form1](https://i.imgur.com/BWysso7.png)

If you click on the button START a new menu opens in which you have to choose your game name and put your own avatar picture if you'd like, otherwise a default avatar pictures will be placed for you. You can also choose at which difficulty you want to play which actually changes the time how long you have to try answers for the question.
![ChooseGame](https://i.imgur.com/vvdX8yI.png)

In this menu you can also choose if you want to play the game in Full Screen Mode or Windowed mode as well as if you want the game to start with a song or have sound effects. 

Here you can also look at the Top 10 highscores and check if you're one of the top 10 and how high you've scored last game you played. You can also add a question to the game which adds one questions to the already added given questions in the game. This feature is just a bonus and shouldn't be used by players. It's added solely for this project.
![AddQuestions, HighScores](https://i.imgur.com/XEylzgd.png)

The next thing you can do is finally Start the main game with your added settings in which you have to guess answers to questions which were gathered from the students of the faculty in Macedonia called FINKI. With clicking the button Skip Question you can change the questions if you don't know any more answers or can't think of any or you've finished answering it. With adding an answer to the text field and clicking on ENTER or on the button TRY your answer will be evaluated and revealed in the fields that have questionmarks. You can also pause the game by clicking on the PAUSE text, the question will be hidden and the timer will be stopped. After that the Pause will be changed to Continue and clicking on it again will Continue the same game you were playing at the time you stopped it.
![MainGame](https://i.imgur.com/46NjgS6.png)

There is also a button called EXIT GAME with which you can finish the main game and go to the Maze Finale round. If the Maze Finale is passed, a screen will show accordingly if you've won the game or lost the game. The Maze Game is played by using the Up, Down, Left and Right controls on your keyboard, you can't pass the orange lines and you need to get to the green field.
![MazeFinale](https://i.imgur.com/fRBQTgK.png)


# Solution to the problem

* The data for the questions and the list of the best 10 players are kept in two seperate text documents which are situated in the folder FinkiFeud/bin/Debug/ so the data can be easily accessed and saved. 

* This project has many forms for showing the different views of the application
The start form called Form1 is the form from which the program starts. After clicking the start button of this form a new form opens up called ChooseGame in which you can put your game settings. From ChooseGame you can open up three other forms, one for the top 10 high scored (HighScores), one for adding a new question to the game (AddQuestions) and a third one from which you can start the main game (MainGame). Before the MainGame shows up there is a form for a splash screen (SplashScreen) in which the player is greeted. After the MainGame is finished a new form opens for the Maze Finale round (MazeFinale) in which a new Maze is generated every time that needs to be passed. After the Maze Finale round two new forms can open up accordingly if you lose (Lose) or win the game (Win). From the Lose or Win forms you can go back to the starting form (Form1).

* For the purpose of keeping the game data there are a couple of helping classes
  * Player is a class that keeps the data for the current player, how much points he has, which picture he's chosen, which difficulty and which name he's chosen. 
  * PlayerDoc is a class that keeps the current player and adds the game settings for him, it calculates the score for the player and sets the time according to the difficulty the player has chosen in the settings.
  * MazePlayer is a class that inherits from the Player class for with which the movement and drawing of the player in the Maze Finale round is set.
  
* This project also uses plenty of resources like the music and sound effects, the pictures for the backgrounds of the forms and appearance of the buttons, the pictures for the logo of the game FinkiFeud and the picture for the default avatar that is set if the player doesn't choose his own picture.

# Description of the GameDone function in MainGame.cs

GameDone is a function that is called when the main game is finished. At first the timer is stopped so the time for the game no longer runs. Then the player for the form MazeFinale is created. A new form MazeFinale is created in a new dialog that runs until the game is finished. If in the MazeFinale form the player has reached the end (the green block in the MazeFinale form) or hasn't reached it at all it's set whether he has passed the maze or not and the score is set accordingly and the MazeFinale form is closed. If the player won the game that will be set and a new window will be opened accordingly (Win or Lose window). If the game was won the score is updated and the player is added to the list of the highscores in the text document and set that the game has finished and closed the window. The difference when the game is lost is only that the score is just set to zero.

```c# 

public void gameDone(){
            //close game
            timer1.Stop();

            mazePlayer = new MazePlayer(mainGame.Score, mainGame.MainPlayer.Name, mainGame.MainPlayer.Difficulty, mainGame.MainPlayer.PlayerIcon, new Point(0, 0));

            MazeFinale mazeGame = new MazeFinale();
            this.Hide();
            if (mazeGame.ShowDialog() == DialogResult.Cancel)
            {
                if (MazeFinale.atEnd == true)
                {
                    mainGame.passedMaze = true;
                    mainGame.updateScore(0);
                    finalScore = mainGame.Score;
                    mazeGame.Close();
                }
            }
            if (MazeFinale.atEnd==true)
            {
                Win gameWon = new Win();
                this.Hide();
                if (gameWon.ShowDialog() == DialogResult.Cancel)
                {
                    addPlayerInText();
                    gameFinished = true;
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                Lose gameLost = new Lose();
                if (gameLost.ShowDialog() == DialogResult.Cancel)
                {
                    mainGame.Score = 0;
                    gameFinished = true;
                    this.Close();
                }
            }
    }
```
