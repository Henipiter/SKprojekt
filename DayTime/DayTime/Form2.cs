﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace DayTime
{
    public partial class Form2 : Form
    {
        private Form obj;
        private Form1 mainForm;
        private Socket fd;
        private IPEndPoint endPoint = null;
        delegate void setThreadedtextBox3UsernameCallback(String text);
        delegate void setThreadedtextBox4ForumnameCallback(String text);
        delegate void setThreadedForumListBoxCallback(String text);
        delegate void setThreadedUserListBoxCallback(String text);
        delegate void setThreadedtextBox1ChatCallback(String text);
        delegate void setThreadedtextBox2ChatCallback(String text);
        delegate void setThreadedForumChangeButtonCallback(bool status);
        delegate void setThreadedForumAddButtonCallback(bool status);
        delegate void setThreadedForumDeleteButtonCallback(bool status);
        delegate void setThreadedForumRefreshButtonCallback(bool status);
        delegate void setThreadedUserRefreshButtonCallback(bool status);
        delegate void setThreadedUserWriteButtonCallback(bool status);
        delegate void setThreadedLogoutButton1Callback(bool status);
        delegate void setThreadedSendButtonCallback(bool status);
        public Form2(Socket socketFd,string username, IPEndPoint end, Form formm)
        {
            InitializeComponent();
            this.obj = this;
            this.fd = socketFd;
            this.endPoint = end;
            this.mainForm = formm as Form1;
            this.setThreadedtextBox3Username(username);
            setThreadedLogoutButton1(false);
            setThreadedRefreshUserButton(false);
            setThreadedRefreshForumButton(false);
            setThreadedChangeForumButton(false);
            setThreadedAddForumButton(false);
            setThreadedDeleteForumButton(false);
            setThreadedUserWriteButton(false);
            setThreadedSendButton(false);
            //receive(fd);
        }

        private void setThreadedSendButton(bool status)
        {
            if (this.SendButton.InvokeRequired)
            {
                setThreadedSendButtonCallback buttonCallback = new setThreadedSendButtonCallback(setThreadedSendButton);
                this.obj.Invoke(buttonCallback, status);
            }
            else
            {
                this.SendButton.Enabled = status;

            }
        }
        private void setThreadedLogoutButton1(bool status)
        {
            if (this.button1.InvokeRequired)
            {
                setThreadedLogoutButton1Callback buttonCallback = new setThreadedLogoutButton1Callback(setThreadedLogoutButton1);
                this.obj.Invoke(buttonCallback, status);
            }
            else
            {
                this.button1.Enabled = status;

            }
        }
        private void setThreadedRefreshUserButton(bool status)
        {
            if (this.UserRefreshButton.InvokeRequired)
            {
                setThreadedUserRefreshButtonCallback buttonCallback = new setThreadedUserRefreshButtonCallback(setThreadedRefreshUserButton);
                this.obj.Invoke(buttonCallback, status);
            }
            else
            {
                this.UserRefreshButton.Enabled = status;

            }
        }
        private void setThreadedRefreshForumButton(bool status)
        {
            if (this.ForumRefreshButton.InvokeRequired)
            {
                setThreadedForumRefreshButtonCallback buttonCallback = new setThreadedForumRefreshButtonCallback(setThreadedRefreshForumButton);
                this.obj.Invoke(buttonCallback, status);
            }
            else
            {
                this.ForumRefreshButton.Enabled = status;

            }
        }
        private void setThreadedChangeForumButton(bool status)
        {
            if (this.ForumChangeButton.InvokeRequired)
            {
                setThreadedForumChangeButtonCallback buttonCallback = new setThreadedForumChangeButtonCallback(setThreadedChangeForumButton);
                this.obj.Invoke(buttonCallback, status);
            }
            else
            {
                this.ForumChangeButton.Enabled = status;
                
            }
        }
        private void setThreadedAddForumButton(bool status)
        {
            if (this.ForumAddButton.InvokeRequired)
            {
                setThreadedForumAddButtonCallback buttonCallback = new setThreadedForumAddButtonCallback(setThreadedAddForumButton);
                this.obj.Invoke(buttonCallback, status);
            }
            else
            {
                this.ForumAddButton.Enabled = status;
            }
        }
        private void setThreadedDeleteForumButton(bool status)
        {
            if (this.ForumDeleteButton.InvokeRequired)
            {
                setThreadedForumDeleteButtonCallback buttonCallback = new setThreadedForumDeleteButtonCallback(setThreadedDeleteForumButton);
                this.obj.Invoke(buttonCallback, status);
            }
            else
            {
                this.ForumDeleteButton.Enabled = status;
            }
        }
        private void setThreadedUserWriteButton(bool status)
        {
            if (this.UserWriteButton.InvokeRequired)
            {
                setThreadedUserWriteButtonCallback buttonCallback = new setThreadedUserWriteButtonCallback(setThreadedUserWriteButton);
                this.obj.Invoke(buttonCallback, status);
            }
            else
            {
                this.UserWriteButton.Enabled = status;
            }
        }

        private void setThreadedtextBox3Username(String text)
        {
            if (this.textBox3.InvokeRequired)
            {
                setThreadedtextBox3UsernameCallback textBoxCallback = new setThreadedtextBox3UsernameCallback(setThreadedtextBox3Username);
                this.obj.Invoke(textBoxCallback, text);
            }
            else
            {
                this.textBox3.Text = text;
            }
        }
        private void setThreadedtextBox4Forumname(String text)
        {
            if (this.textBox4.InvokeRequired)
            {
                setThreadedtextBox4ForumnameCallback textBoxCallback = new setThreadedtextBox4ForumnameCallback(setThreadedtextBox4Forumname);
                this.obj.Invoke(textBoxCallback, text);
            }
            else
            {
                //text = text.Substring(0, text.Length - 2);
                this.textBox4.Text = text;
            }
        }

        public void setThreadedForumListBox(String text)
        {
            if (this.ForumListBox.InvokeRequired)
            {
                setThreadedForumListBoxCallback textBoxCallback = new setThreadedForumListBoxCallback(setThreadedForumListBox);
                this.obj.Invoke(textBoxCallback, text);
            }
            else
            {
                //text = text.Substring(0, text.Length - 2);
                this.ForumListBox.Text = text;
            }
        }

        public void setThreadedUserListBox(String text)
        {
            if (this.UserListBox.InvokeRequired)
            {
                setThreadedUserListBoxCallback textBoxCallback = new setThreadedUserListBoxCallback(setThreadedUserListBox);
                this.obj.Invoke(textBoxCallback, text);
            }
            else
            {
                //text = text.Substring(0, text.Length - 2);
                this.UserListBox.Text = text;
            }
        }

        public void setThreadedChatbox1(String text)
        {
            if (this.textBox1.InvokeRequired)
            {
                setThreadedtextBox1ChatCallback textBoxCallback = new setThreadedtextBox1ChatCallback(setThreadedChatbox1);
                this.obj.Invoke(textBoxCallback, text);
            }
            else
            {
                //text = text.Substring(0, text.Length - 2);
                this.textBox1.Text += text;
            }
        }
        public void setThreadedChatbox2(String text)
        {
            if (this.textBox1.InvokeRequired)
            {
                setThreadedtextBox2ChatCallback textBoxCallback = new setThreadedtextBox2ChatCallback(setThreadedChatbox2);
                this.obj.Invoke(textBoxCallback, text);
            }
            else
            {
                //text = text.Substring(0, text.Length - 2);
                this.textBox1.Text = text;
            }
        }

        private void ReceiveCallback2(IAsyncResult ar)
        {
            try
            {
                /* retrieve the SocketStateObject */
                SocketStateObject2 state = (SocketStateObject2)ar.AsyncState;
                Socket socketFd = fd;
                
                /* read data */
                int size = socketFd.EndReceive(ar);
                string a;
                char b;
                
                state.m_StringBuilder.Append(Encoding.ASCII.GetString(state.m_DataBuf, 0, size));
                /* get the rest of the data */
                a = state.m_StringBuilder.ToString();
                b = a[a.Length - 1];
                if (b == '\n')
                {
                    /* all the data has arrived */

                    switch (a[0])
                        {
                        case '0':
                            switch (a[1])
                            {
                                case 'Y':
                                    setThreadedLogoutButton1(true);
                                    string mess0 = 7.ToString() + "\n" + 0.ToString() + "\n" + "";
                                    byte[] Buf0 = Encoding.ASCII.GetBytes(mess0);
                                    fd.Send(Buf0, Buf0.Length, 0);
                                    setThreadedRefreshForumButton(true);
                                    setThreadedChangeForumButton(true);
                                    setThreadedAddForumButton(true);
                                    setThreadedDeleteForumButton(true);
                                    //this.Hide();
                                    //mainForm.Hide();
                                    break;
                                case 'N':
                                    MessageBox.Show("Blad logowania");                                    
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 'c':
                            switch (a[1])
                            {
                                case 'Y':
                                    string mess0 = 8.ToString() + "\n" + 0.ToString() + "\n" + "";
                                    byte[] Buf0 = Encoding.ASCII.GetBytes(mess0);
                                    fd.Send(Buf0, Buf0.Length, 0);
                                    mess0 = 7.ToString() + "\n" + 0.ToString() + "\n" + "";
                                    Buf0 = Encoding.ASCII.GetBytes(mess0);
                                    fd.Send(Buf0, Buf0.Length, 0);
                                    setThreadedRefreshUserButton(true);
                                    setThreadedUserWriteButton(true);
                                    setThreadedSendButton(true);
                                    break;
                                case 'N':
                                    MessageBox.Show("Nie znaleziono");
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 'e':
                            string mess1 = 8.ToString() + "\n" + 0.ToString() + "\n" + "";
                            byte[] Buf1 = Encoding.ASCII.GetBytes(mess1);
                            fd.Send(Buf1, Buf1.Length, 0);
                            break;

                        case 'f':
                            mess1 = 7.ToString() + "\n" + 0.ToString() + "\n" + "";
                            Buf1 = Encoding.ASCII.GetBytes(mess1);
                            fd.Send(Buf1, Buf1.Length, 0);
                            break;
                        case 'd':
                            switch (a[1])
                            {
                                case 'Y':
                                    string mess0 = 7.ToString() + "\n" + 0.ToString() + "\n" + "";
                                    byte[] Buf0 = Encoding.ASCII.GetBytes(mess0);
                                    fd.Send(Buf0, Buf0.Length, 0);
                                    
                                    setThreadedRefreshUserButton(false);
                                    setThreadedUserWriteButton(false);
                                    setThreadedSendButton(false);
                                    break;
                                case 'N':
                                    MessageBox.Show("Nie znaleziono");
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case '2':
                            setThreadedChatbox1(a.Substring(1));
                            break;
                        case '1':
                            setThreadedChatbox2(a.Substring(1));
                            this.setThreadedtextBox4Forumname(a.Substring(1));
                            break;
                        case '3':
                            socketFd.Shutdown(SocketShutdown.Both);
                            socketFd.Close();
                            this.mainForm.Show();
                            this.Close(); 
                                
                            break;
                        case 'b':
                            switch (a[1])
                            {
                                case 'Y':
                                    SocketStateObject2 state2 = new SocketStateObject2();
                                    state2.m_SocketFd = fd;
                                    state2.msg = "";
                                    state2.flag = 7;
                                    byte[] Buf2;
                                    string mess2;
                                    mess2 = state2.flag.ToString() + "\n" + state2.msg.Length + "\n" + state2.msg;
                                    Buf2 = Encoding.ASCII.GetBytes(mess2);
                                    fd.Send(Buf2, Buf2.Length, 0);

                                    break;
                                case 'N':
                                    MessageBox.Show("Zla nazwa");
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 'a':
                            this.setThreadedtextBox4Forumname("");
                            this.setThreadedUserListBox("");
                            this.setThreadedChatbox2("");
                            setThreadedRefreshUserButton(false);
                            setThreadedUserWriteButton(false);
                            setThreadedSendButton(false);

                            MessageBox.Show("Forum zostalo usuniete");

                            break;
                        case '7':
                            setThreadedForumListBox(a.Substring(1));
                            break;
                        case '8':
                            setThreadedUserListBox(a.Substring(1));
                            break;
                        
                        default:
                            break;
                    }
                    state = null;
                    state = new SocketStateObject2();
                }
                socketFd.BeginReceive(state.m_DataBuf, 0, 1, 0, new AsyncCallback(ReceiveCallback2), state);
                
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Exception:\t\n" + exc.Message.ToString());
            }
        }
       
        
        private void ForumRefreshButton_Click(object sender, EventArgs e)
        {
            SocketStateObject2 state = new SocketStateObject2();
            state.m_SocketFd = fd;
            state.msg = "";
            state.flag = 7;
            byte[] Buf;
            string mess;
            mess = state.flag.ToString() + "\n" + state.msg.Length + "\n" + state.msg;
            Buf = Encoding.ASCII.GetBytes(mess);
            
           // fd.BeginConnect(endPoint, new AsyncCallback(ConnectCallback2), state);
            fd.Send(Buf, Buf.Length, 0);

           // StartReceiveMess();
            //MessageBox.Show(":::"+state.m_StringBuilder.ToString());
        }
        private void ForumAddButton_Click(object sender, EventArgs e)
        {

            //SocketStateObject2 state = new SocketStateObject2();
            //state.m_SocketFd = fd;
            //state.m_SocketFd.BeginReceive(state.m_DataBuf, 0, SocketStateObject.BUF_SIZE, 0, new AsyncCallback(ReceiveCallback2), state);
            Form4 frm = new Form4(fd, endPoint,4);
            frm.Show();

        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            SocketStateObject2 state = new SocketStateObject2();
            state.m_SocketFd = fd;
            state.msg = this.textBox2.Text.ToString();
            state.flag = 2;
            this.textBox2.Text = null;
            byte[] Buf;
            string mess;
            mess = state.flag.ToString() + "\n" + state.msg.Length + "\n" + state.msg;
            Buf = Encoding.ASCII.GetBytes(mess);

            // fd.BeginConnect(endPoint, new AsyncCallback(ConnectCallback2), state);
            fd.Send(Buf, Buf.Length, 0);
        }

        

        private void ForumDeleteButton_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(fd, endPoint, 5);
            frm.Show();
        }

        

        public void ForumListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocketStateObject2 state = new SocketStateObject2();
            state.m_SocketFd = fd;
            state.msg = "";
            state.flag = 3;
            byte[] Buf;
            string mess;
            mess = state.flag.ToString() + "\n" + state.msg.Length + "\n" + state.msg;
            Buf = Encoding.ASCII.GetBytes(mess);

            // fd.BeginConnect(endPoint, new AsyncCallback(ConnectCallback2), state);
            fd.Send(Buf, Buf.Length, 0);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserWriteButton_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(fd, endPoint);
            frm.Show();
        }

        private void UserRefreshButton_Click(object sender, EventArgs e)
        {

            SocketStateObject2 state = new SocketStateObject2();
            state.m_SocketFd = fd;
            state.msg = "";
            state.flag = 8;
            byte[] Buf;
            string mess;
            mess = state.flag.ToString() + "\n" + state.msg.Length + "\n" + state.msg;
            Buf = Encoding.ASCII.GetBytes(mess);

            // fd.BeginConnect(endPoint, new AsyncCallback(ConnectCallback2), state);
            fd.Send(Buf, Buf.Length, 0);
        }
        public void startReceive()
        {
            SocketStateObject2 state = new SocketStateObject2();
            state.m_SocketFd = fd;
            state.m_SocketFd.BeginReceive(state.m_DataBuf, 0, 1, 0, new AsyncCallback(ReceiveCallback2), state);
        }
        private void UserListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForumChangeButton_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(fd, endPoint, 1);
            this.textBox1.Text = null;
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
    public class SocketStateObject2
    {
        public const int BUF_SIZzE = 1024;
        public byte[] m_DataBuf = new byte[BUF_SIZzE];
        public StringBuilder m_StringBuilder = new StringBuilder();
        public Socket m_SocketFd = null;
        public string msg;
        public int flag;
    }
}
