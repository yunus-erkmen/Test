using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PIWORKSS
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\erkme\\Desktop\\P.I.Works\\Veri.txt");
            ArrayList PLAY_ID = new ArrayList();
            ArrayList SONG_ID = new ArrayList();
            ArrayList CLIENT_ID = new ArrayList();
            ArrayList PLAY_TS = new ArrayList();

            ArrayList SONG_ID10 = new ArrayList();
            ArrayList CLIENT_ID10 = new ArrayList();



            string line;
            int  dist_song;

            while((line = sr.ReadLine()) != null)
            {
                
                string[] data = line.Split('\t');
                string[] date = data[3].Split(' ');
                PLAY_ID.Add(data[0]);
                SONG_ID.Add(data[1]);
                CLIENT_ID.Add(data[2]);
                PLAY_TS.Add(date[0]);
 

            }

            for(int i=0;i<PLAY_TS.Count;i++)
            {
                if(PLAY_TS[i].ToString() == "10/8/2016")
                {
                    SONG_ID10.Add(SONG_ID[i]);
                    CLIENT_ID10.Add(CLIENT_ID[i]);


                }
            }


            for(int j=0;j<SONG_ID10.Count; j++)
            {
                for(int k=j+1;k<CLIENT_ID10.Count; k++)
                {
                    Console.WriteLine("Comparison..");
                    if ((SONG_ID10[j].ToString() == SONG_ID10[k].ToString()) && (CLIENT_ID10[j].ToString() == CLIENT_ID10[k].ToString()))
                    {
                        SONG_ID10.Remove(SONG_ID10[j]);
                        CLIENT_ID10.Remove(CLIENT_ID10[j]);
                        Console.WriteLine("Find equal-not distinct");
                        
                    }
                }
            }


            SONG_ID10.Sort();
            CLIENT_ID10.Sort();


            int temp = 0;
            int max_distinct=0;
            int distinct346=0;



            for(int i=1;i<SONG_ID10.Count;i++)
            {
                temp++;
                if((SONG_ID10[i-1].ToString()) != (SONG_ID10[i].ToString()))
                {
                    if(max_distinct<temp)
                    {
                        max_distinct = temp;
                    }

                    if(temp==346)
                    {
                        distinct346++;
                    }
                    
                    temp = 0;
                }
                
                
            }

            Console.WriteLine(" maximum number of distinct songs  played: " + max_distinct);
            Console.WriteLine(" 346 distinct songs users count :" + distinct346);
            

            sr.Close();

           // Console.WriteLine(SONG_ID[0].ToString() +"------"+ PLAY_TS[0].ToString());
            
          

                
            
            

            Console.ReadLine();
        }
    }
}
