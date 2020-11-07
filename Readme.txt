Untuk project simple client server mohon sesuaikan penyimpanan file message.txt

try
            {
                //Sesuaikan dengan path local
                string path = "D:\\Learning\\Csharp\\SimpleClientServer\\SimpleClientServer\\SimpleClientServer\\Log\\Message.txt";
                string strMessage = String.Format("{0}", message);
                FileStream objFilestream = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                objStreamWriter.WriteLine(strMessage);
                objStreamWriter.Close();
                objFilestream.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
