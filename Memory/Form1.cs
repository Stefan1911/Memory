using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataLib;

namespace Memory
{
    public partial class Form1 : Form
    {
        string cartFoldder;
        string cardBack;
        string emptyCard;

        card firstCard;
        card secondCard;
        int reveledPears;

        Settings gameSettings;
        int gameTime;

        public Form1()
        {
            InitializeComponent();
            cartFoldder = "..\\..\\Assets\\";
            cardBack = null; //"C:\\Users\\bogos\\Downloads\\pepes\\back.png";
            emptyCard = "..\\..\\Assets\\noPepe.png";
            firstCard = null;
            secondCard = null;
            reveledPears = 0;
            gameSettings = null;
            gameTime = 0;
        }

        #region methodes
        private void inicializeGame(Settings GameSettings)
        {

        }
        private void resizeGrid(int rows,int columns)
        {
            this.clearGrid();


            for(int i = 0; i < rows; ++i)
            {
                gameTable.RowStyles.Add(new ColumnStyle(SizeType.Percent, 100 / rows));
                gameTable.RowCount++;
            }
            for (int i = 0; i < columns; ++i)
            {
                gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
                gameTable.ColumnCount++;
            }
        }
        private void clearGrid()
        {
            while (gameTable.ColumnCount != 0)
            {
                gameTable.ColumnStyles.RemoveAt(0);
                gameTable.ColumnCount--;
            }
            while (gameTable.RowCount != 0)
            {
                gameTable.RowStyles.RemoveAt(0);
                gameTable.RowCount--;
            }
        }
        private void newGame(Settings gameSettings)
        {
                this.gameSettings = gameSettings;
                this.clearBoar();
                this.reveledPears = 0;
                this.gameTime = 0;
                this.resizeGrid(gameSettings.Rows, gameSettings.Columns);
                this.insertPictures(gameSettings.Pears,gameSettings.Pictures);
                gameTimer.Start();    
        }
        private void insertPictures(int numberOfPears,int numberOfPictures)
        {
            List<card> cardList = this.getCards(numberOfPears, numberOfPictures);
            card cardBox;
            Random rng = new Random();

            for (int i  = 0; i < gameTable.RowCount; ++i)
            {
                for (int j = 0; j < gameTable.ColumnCount; ++j)
                {             
                    int index = rng.Next(0, cardList.Count);
                    cardBox = cardList.ElementAt(index);
                    cardList.RemoveAt(index);
                    cardBox.Dock = DockStyle.Fill;
                    cardBox.Click += new EventHandler(this.selectHandler);
                    gameTable.Controls.Add(cardBox, j, i);
                } 
            }
        }
        private void selectHandler(object sender,EventArgs e)
        {
            if (firstCard != null && secondCard != null)
                return;
            card clickedCard = ((card)sender);
            if(!clickedCard.Reveled)
            {
                clickedCard.flipCard();
                if (!clickedCard.EmptyCard)
                {
                    if (this.firstCard == null)
                    {
                        firstCard = clickedCard;
                    }
                    else if (clickedCard.compereTo(firstCard))
                    {
                        reveledPears++;
                        firstCard = null;
                        secondCard = null;
                        this.chekForWin();
                    }
                    else
                    {
                        this.secondCard = clickedCard;
                        lagTimer.Start();
                    }
                }
               
            }
        }
        private void clearBoar()
        {
            while(gameTable.Controls.Count != 0){
                gameTable.Controls.RemoveAt(0);
            }
            this.clearGrid();
        }
        private void revealBoard()
        {
            gameTimer.Stop();
            foreach (Control card in gameTable.Controls)
            {
                if (!((card)card).Reveled)
                    ((card)card).flipCard();
            }
            MessageBox.Show("your time is " + gameTime + " sec.");
        }
        private void chekForWin()
        {
            if(reveledPears == gameSettings.Pears)
            {
                gameTimer.Stop();
                foreach (Control card in gameTable.Controls)
                {
                    if (!((card)card).Reveled)
                    {
                        ((card)card).flipCard();
                    }
                }
                MessageBox.Show("YOU DID IT!!\n your time is "+gameTime);
            }
            
        }
        private List<card> getCards(int numberOfPears, int numberOfPictures)
        {
            List<card> pictureList = new List<card>();
            Random rng = new Random();

            for (int i = 0; i < numberOfPictures; ++i)
            {
                pictureList.Add(new card(cartFoldder + i + ".png", cardBack,false,i));
                pictureList.Add(new card(cartFoldder + i + ".png", cardBack,false,i));
            }
            for (int i = numberOfPictures; i < numberOfPears; ++i)
            {
                int index = rng.Next(0, numberOfPictures);
                pictureList.Add(new card(cartFoldder + index + ".png", cardBack,false,index));
                pictureList.Add(new card(cartFoldder + index + ".png", cardBack,false,index));
            }
            for (int i = numberOfPears * 2; i < gameTable.ColumnCount * gameTable.RowCount; ++i)
            {
                pictureList.Add(new card(emptyCard,cardBack,true,-1));
            }
            return pictureList;
        }
        #endregion

        #region events
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGameFrom ngForm = new NewGameFrom();
            if (ngForm.ShowDialog() == DialogResult.OK)
            {
                newGame(ngForm.Settings);
            };
        }
        #endregion

        private void resizeGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resizeGrid(10,10);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            this.gameTime++;
        }

        private void lagTimer_Tick(object sender, EventArgs e)
        {
            lagTimer.Stop();
            firstCard.flipCard();
            secondCard.flipCard();
            firstCard = null;
            secondCard = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings startUpConfig = Settings.loadFromFile("..\\..\\settings\\startUpConfig.ini");
            this.newGame(startUpConfig);
        }


        private void saveSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.saveToFile(this.gameSettings, fileDialog.FileName);
            }
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {
            newGame(this.gameSettings);
        }

        private void surrenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.revealBoard();
        }
    }
}
