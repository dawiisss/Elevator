using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static TheLift.GlobalVariables;

namespace TheLift
{
    public partial class Form1 : Form
    {
        //Creates a new instance of Log
        Log log = new Log();
        public Form1()
        {
            //Initializes All the components
            InitializeComponent();
            //This makes sure that the user cannot resize the program
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        //This method is for the hide/show doors button
        private void button4_Click(object sender, EventArgs e)
        {
            //If It is equal to Hide doors then it will make all the door panels invisible.
            if (button4.Text == "Hide Doors")
            {
                firstleftdoor.Visible=false;
                firstrightdoor.Visible = false;
                groundleftdoor.Visible = false;
                groundrightdoor.Visible = false;
                button4.Text = "Show Doors";
            }
            
            //If it is equal to Show Doors then it will make all the door visible.
            else if (button4.Text == "Show Doors")
            {
                firstleftdoor.Visible = true;
                firstrightdoor.Visible = true;
                groundleftdoor.Visible = true;
                groundrightdoor.Visible = true;
                button4.Text = "Hide Doors";
            }

        }
        //This is a method for the timer that will move the lift down and add it to the database
        private async void timerDown_Tick(object sender, EventArgs e)
        {
            //Creates a new sound player 
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@""+ soundPath +"");
            //If timerUp is enabled then timerDown,OpenUpDoors,OpenDownDoors can't be enabled
            if (timerUp.Enabled == true)
            {
                timerDown.Enabled = false;
                openUpDoors.Enabled = false;
                openDownDoors.Enabled = false;
            }
            //This will move the lift down to ground floor each second the Top argument will increment by 5
            lift.Top = lift.Top + 5;
            //This makes the lift going down indicator visible
            downArrow.Visible = true;
            //If lift.Top is equal to 278 then the lift will stop and it will send the data to the database
            if (lift.Top == 278)
            {
                String status = "Lift going down";
                addToDb(status);
                //This will move the lift up by 1 so that it will give it that lift up effect
                lift.Top = lift.Top - 1;
                //This stops the timer
                timerDown.Stop();
                //This will change the status of the labels to G groundfloor
                currentFloor.Text = "G";
                currentFloorUp.Text = "G";
                currentFloorGround.Text = "G";
                //This makes the going down indicator not visible
                downArrow.Visible = false;
                //This will refresh the logs listview 
                log.refreshList();
                //This plays the beep sound that indicates that the lift has arrived
                player.Play();
                //This will start the timer to open the ground floor doors
                openDownDoors.Start();
                //This will put a task delay which will put a delay of 5 seconds
                await PutTaskDelay();
                //After 5 seconds it will close the doors
                closeDownDoors.Start();

            }

        }

        //This is a method that will move the lift up and it will add it to the database
        private async void timerUp_Tick(object sender, EventArgs e)
        {
            //Creates a new sound player
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@""+ soundPath +"");
            //If timerDown is enabled then timerUp,OpenUpDoors,OpenDownDoors cannot be enabled
            if (timerDown.Enabled == true) {
               timerUp.Enabled = false;
               openUpDoors.Enabled = false;
               openDownDoors.Enabled = false;
            }
            //This will me the lift up to first floor each seond the Top argument will increment by 5
            lift.Top = lift.Top - 5;
            //This will make the going up indicator visible.
            upArrow.Visible = true;
            //This will make the lift stop when it reaches the top and it will send the data to the database
            if (lift.Top == 12)
            {
                String status = "Lift going up";
                addToDb(status);
                //This will stabilize the lift position and make sure that the timerDown will work
                lift.Top = lift.Top + 1;
                //Tis will stop the timerUp timer
                timerUp.Stop();
                //This will set the current floor to the first floor
                currentFloor.Text = "1";
                currentFloorUp.Text = "1";
                currentFloorGround.Text = "1";
                //This will make the going up indicator invisible
                upArrow.Visible = false;
                //This will refresh the log
                log.refreshList();
                //This will play the beep sound
                player.Play();
                //This will start the timer to open the first floor doors
                openUpDoors.Start();
                //This will put a task delay for 5 seconds
                await PutTaskDelay();
                //And finally this will start the timer to close the first floor doors
                closeUpDoors.Start();
            
            }
        }

        private async void buttonUp_Click(object sender, EventArgs e)
        {
            //This will make sure that if the doors are open on the first floor the lift will not respond the requests
            if (firstleftdoor.Width < 184 && firstrightdoor.Width < 184)
            {
                return;
            }
            //This will make sure that if the doors are open on the ground floor the lift will not respond to requests
            if (groundleftdoor.Width < 184 && groundrightdoor.Width < 184)
            {
                return;
            }
            //This will make down doors are closing 
            if (closeDownDoors.Enabled == true)
            {
                return;
            }
            //This will make sure that if the first floor doors are closing the button Up won't work
            if (closeUpDoors.Enabled == true)
            {
                return;
            }
            //This will make sure that if the ground floor doors are opening the button Up won't work
            if (openDownDoors.Enabled == true)
            {

                return;
            }
            //This will make sure that if the first floor doors are opening the button Up won't work
            if (openUpDoors.Enabled == true)
            {

                return;

            }
            //This will check if the lift is at the First floor if it is then it will not do anything
            if (lift.Top == 277)
            {

            }
            //This will check if the lift is down if it is it will check
            if (lift.Top > 13)
            {
                //If the timerDown is enabled then do nothing
                if (timerDown.Enabled == true)
                {

                }
                //Otherwise start the timerUP and stop the timerDown
                else
                {
                    timerUp.Start();
                    timerDown.Stop();
                }
            }
            //After everything is finished it will open the doors on the firt floor and it will put a task delay and then open close the doors
            else {
                openUpDoors.Start();
                await PutTaskDelay();
                closeUpDoors.Start();
                await PutTaskDelay();
            }
        }

        private async void buttonDown_Click(object sender, EventArgs e)
        {
            //This will make sure that if the doors are open on the first floor the lift will not respond to requests
            if (firstleftdoor.Width < 184 && firstrightdoor.Width < 184)
            {
                return;
            }
            //This will make sure that if the doors are open on the ground floor the lift will not respond to requests
            if (groundleftdoor.Width < 184 && groundrightdoor.Width < 184)
            {
                return;
            }
            //This will sure that if the ground floor doors are closing  then  the lift will not respond to requests
            if (closeDownDoors.Enabled == true)
            {
                return;
            }
            //This will make sure that if the first floor dors are closing the the lift will not respond to requests
            if (closeUpDoors.Enabled == true)
            {
                return;
            }
            //This will make sure that if the ground floor doors are opening then the lift will not respond to requests
            if (openDownDoors.Enabled == true)
            {

                return;
            }
            //This will make sure that if the first floor doors are opening then the lift will not respond to requests
            if (openUpDoors.Enabled == true)
            {

                return;

            }
            //If the lift is downstairs then it will not respond to requests to go dwon
            if (lift.Top == 13)
            {
            }

            //If the lift is anywhere but downstairs then
            if (lift.Top < 277)
            {
                //If the timerUp is enabled then it will not respond to requests
                if (timerUp.Enabled == true)
                {

                }
                //Otherwise it will start the go down timer and it will stop the timerUp
                else
                {
                    timerDown.Start();
                    timerUp.Stop();
                }

            }
            else {
                //This will start opening the doors on the ground floor 
                openDownDoors.Start();
                //Now it will wait 5 seconds
                await PutTaskDelay();
                //Now it will close the ground floor doors
                closeDownDoors.Start();
                //Now it will wait 5 seconds again
                await PutTaskDelay();
            }
        }

        private void openUpDoors_Tick(object sender, EventArgs e)
        {
            //This will disable the floor buttons
            floorButton(0);
            //This will start opening the first floor doors
            firstleftdoor.Width = firstleftdoor.Width - 6;
            firstrightdoor.Width = firstrightdoor.Width - 6;
            //This will make sure that the right doors will open to the left and not to the right
            firstrightdoor.Location = new Point(firstrightdoor.Location.X + 6, firstrightdoor.Location.Y);

            //Once the doors open then it will send the data to the database and it will stop the timer
            if (firstleftdoor.Width == 4 && firstrightdoor.Width == 4)
            {
                addToDb("Opening First Floor Door");
                //This will refresh the listview in the log form
                log.refreshList();
                //This will stabalize the location of the lift
                firstleftdoor.Width = firstleftdoor.Width + 4;
                firstrightdoor.Width = firstrightdoor.Width + 4;
                firstrightdoor.Location = new Point(firstrightdoor.Location.X - 4, firstrightdoor.Location.Y);
                //This will enable buttons for floors
                floorButton(1);
                //This will stop the timer
                openUpDoors.Stop();
            }
        }


        private void openDownDoors_Tick(object sender, EventArgs e)
        {
            //This will disable the floor buttons
            floorButton(0);
            //This will start opening the ground floor doors
            groundleftdoor.Width = groundleftdoor.Width - 6;
            groundrightdoor.Width = groundrightdoor.Width - 6;
            //This will make sure that the right doors will open to the left and not to the right
            groundrightdoor.Location = new Point(groundrightdoor.Location.X + 6, groundrightdoor.Location.Y);

            //Once the doors open then it will send the data to the database and it will stop the timer
            if (groundleftdoor.Width == 4 && groundrightdoor.Width == 4)
            {
                addToDb("Opening Ground Floor Door");
                //This will refresh the listview in the log form
                log.refreshList();
                //This will stabalize the doors location
                groundleftdoor.Width = groundleftdoor.Width + 4;
                groundrightdoor.Width = groundrightdoor.Width + 4;
                groundrightdoor.Location = new Point(groundrightdoor.Location.X - 4, groundrightdoor.Location.Y);
                //This will enable buttons for floors
                floorButton(1);
                //This will stop the timer
                openDownDoors.Stop();

            }
        }
        //This will create a new async method called PutTaskDelay
        async Task PutTaskDelay()
        {
            //This will make the program wait 5 seconds
            await Task.Delay(5000);
        }

        private void closeDownDoors_Tick(object sender, EventArgs e)
        {
            //This will disable the floor buttons
            floorButton(0);
            //This will start opening the ground floor doors
            groundleftdoor.Width = groundleftdoor.Width + 6;
            groundrightdoor.Width = groundrightdoor.Width + 6;
            //This will make sure that the right doors will open to the left and not to the right
            groundrightdoor.Location = new Point(groundrightdoor.Location.X - 6, groundrightdoor.Location.Y);
            //Once the doors close then it will send the data to the database and it will stop the timer
            if (groundleftdoor.Width == 188 && groundrightdoor.Width == 188)
            {
                addToDb("Closing Ground Floor Door");
                //This will refresh the listview of the log form
                log.refreshList();
                //This will stabilize the doors position
                groundleftdoor.Width = groundleftdoor.Width - 4;
                groundrightdoor.Width = groundrightdoor.Width - 4; 
                groundrightdoor.Location = new Point(groundrightdoor.Location.X + 4, groundrightdoor.Location.Y);
                //This will enable the floor buttons.
                floorButton(1);
                //This will stop the timer.
                closeDownDoors.Stop();


            }
        }

        private void closeUpDoors_Tick(object sender, EventArgs e)
        {
            floorButton(0);
            //This will close the first floor doors
            firstleftdoor.Width = firstleftdoor.Width + 6;
            firstrightdoor.Width = firstrightdoor.Width + 6;
            firstrightdoor.Location = new Point(firstrightdoor.Location.X - 6, firstrightdoor.Location.Y);

            //Once the doors are closed it will send the status tot he database
            if (firstleftdoor.Width == 188 && firstrightdoor.Width == 188)
            {
                addToDb("Closing First Floor Door");
                //This will refresh the log listview.
                log.refreshList();
                //This will stabilize the doors
                firstleftdoor.Width = firstleftdoor.Width - 4;
                firstrightdoor.Width = firstrightdoor.Width - 4;
                firstrightdoor.Location = new Point(firstrightdoor.Location.X + 4, firstrightdoor.Location.Y);
                //This makes the buttons visible again
                floorButton(1);
                //This stops the timer
                closeUpDoors.Stop();
            }
        }

        private async void firstFloorButton_Click(object sender, EventArgs e)
        {
            //If the doors on the ground floor are closing do nothing
            if (closeDownDoors.Enabled == true)
            {
                return;
            }
            //If the doors on the first floor are closing do nothing
            if (closeUpDoors.Enabled == true)
            {
                return;
            }
            //If the doors on the ground floor are opening do nothing
            if (openDownDoors.Enabled == true) {

                return;
            }
            //If the doors on the first floor are opening do nothing
            if (openUpDoors.Enabled == true) {

                return;
                
            }
            //If the lift is on the top floor do nothing
            if (lift.Top == 13)
            {

                return;
            }
            //If lift is on the bottom floor and the doors are closed then start the lift to go up and change the coloring of the button
            if (lift.Top == 277 && groundleftdoor.Width == 184) {
                //Set the  different color on the button
                firstFloorButton.BackColor = Color.GreenYellow;
                //Start the timer to move the lift to the first floor
                timerUp.Start();
                //Wait 5 seconds
                await PutTaskDelay();
                //Set the button back to the default state
                firstFloorButton.BackColor = SystemColors.Control;
                firstFloorButton.UseVisualStyleBackColor = true;
            }
        }

        private async void groundFloorButton_Click(object sender, EventArgs e)
        {
            //If the doors on the ground floor are closing do nothing
            if (closeDownDoors.Enabled == true)
            {
                return;
            }
            //If the doors on the first floor are closing do nothing
            if (closeUpDoors.Enabled == true)
            {
                return;
            }
            //If the doors on the ground floor are opening do nothing
            if (openDownDoors.Enabled == true) {
                return;
            }
            //If the doors on the first floor are opening do nothing
            if (openUpDoors.Enabled == true) {
                return;
            }
            //If the lift is on the ground floor do nothing
            if (lift.Top == 277) {
                return;
            }
            //If the lift top floor and the doors are closed start the timer to move the lift to the ground floor
            if (lift.Top == 13 && firstleftdoor.Width == 184) {
                //Set the  different color on the button
                groundFloorButton.BackColor = Color.GreenYellow;
                //Start the timer to move the lift to the ground floor
                timerDown.Start();
                //Wait 5 seconds
                await PutTaskDelay();
                //Set the button back to the default state
                groundFloorButton.BackColor = SystemColors.Control;
                groundFloorButton.UseVisualStyleBackColor = true;
            }
        }

        private void OpenLogButton_Click(object sender, EventArgs e)
        {
            //Open the Log window
            log.Show();
        }

        private async void openDoors_Click(object sender, EventArgs e)
        {
            //If the lift is on the ground floor and the doors are closed then start the timer to open the doors
            if (lift.Top == 277 && groundleftdoor.Width == 184)
            {
                //Set the color the of the button
                openDoorsButton.BackColor = Color.GreenYellow;
                //Start the timer to open the doors
                openDownDoors.Start();
                //Wait 5 seconds
                await PutTaskDelay();
                //Start the timer to close the doors
                closeDownDoors.Start();
                //Set the button to default
                openDoorsButton.BackColor = SystemColors.Control;
                openDoorsButton.UseVisualStyleBackColor = true;
            }
            //If the lift is on the first floor and the doors are closed then start the timer to open the doors
            if (lift.Top == 13 && firstleftdoor.Width == 184)
            {
                //Set the color the of the button
                openDoorsButton.BackColor = Color.GreenYellow;
                //Start the timer to open the doors
                openUpDoors.Start();
                //Wait 5 seconds
                await PutTaskDelay();
                //Start the timer to close the doors
                closeUpDoors.Start();
                //Set the button to default
                openDoorsButton.BackColor = SystemColors.Control;
                openDoorsButton.UseVisualStyleBackColor = true;
            }
        }
        private void addToDb(String status) {
            String elevatorStatus = status;
            //Get the date and time 
            String getTime = DateTime.Now.ToString("HH:mm:ss tt");
            String getDate = DateTime.Now.ToString("dd MMM yyyy");
            //Intialize the dbConnection as empty string
            string dbConnection = null;
            OleDbConnection connection;
            //This sets the value of the dbConnection
            dbConnection = "Provider="+ providerPath +";" + @"data source=" + dbPath + "";
            connection = new OleDbConnection(dbConnection);
            //This initializes the string InsertQuery and sets its value                
            String InsertQuery = "INSERT INTO Operations (ElevatorStatus,OperationTime,OperationDate) VALUES ('" + elevatorStatus + "','" + getTime + "','" + getDate + "')";
            try
            {
                //This opens a new database connection                    
                connection.Open();
                //This initializes a new OleDbCommand with the InsertQuery and database connection                    
                OleDbCommand insert = new OleDbCommand(InsertQuery, connection);
                insert.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error" + a);
            }
            finally
            {
                //This closes the connection with the database
                connection.Close();
            }

        }
        private void floorButton(int enabled) {
            if (enabled == 1)
            {
                //This will enable buttons for floors
                firstFloorButton.Enabled = true;
                groundFloorButton.Enabled = true;
            }
            else if (enabled == 0)
            {
                //This will disable the floor buttons
                firstFloorButton.Enabled = false;
                groundFloorButton.Enabled = false;
            }


        }

    }
}
