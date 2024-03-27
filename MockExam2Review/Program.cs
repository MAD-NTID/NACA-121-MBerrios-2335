const string readFrom = "movies.txt";
const string writeTo = "results.txt";

IPlayListMedia<Video> playListMediaQueue = new PlayListMediaQueue<Video>();
IPlayListMedia<Video> playListMediaStack = new PlayListMediaStack<Video>();

//  Read the movies.txt file and enqueue each of the video
if(File.Exists(readFrom))
{
    StreamReader sr = new StreamReader(readFrom);

    // End of Stream indicates if it has reached the end of the file
    // Use the inverse ! to force the loop to continue as long as the file has "NOT" reached the end of stream
    bool skipHeader = false;
    while(!sr.EndOfStream)
    {
        //  We need to skip the header
        if(!skipHeader)
        {
            //  Read the next line and do nothing
            sr.ReadLine();
            skipHeader = true;
        }

        //  We read each line and create video and Enqueue and Stack
        string[] data = sr.ReadLine().Split(',');

        Video video = new Video(data[0], data[1], data[2]);
        
        Console.WriteLine($"Adding {video} to the Queue");
        playListMediaQueue.Add(video);

        Console.WriteLine($"Adding {video} to the stack");
        playListMediaStack.Add(video);
    }

    sr.Close();

    Console.WriteLine("\nAll video(s) are loaded in the queue and stack playlists");

    //  Show the queue
    Console.WriteLine(playListMediaQueue);

    Console.WriteLine();

    //  Show the stack
    Console.WriteLine(playListMediaStack);

    //  Finally, write stack to file
    StreamWriter sw = new StreamWriter(writeTo);
    sw.WriteLine($"Stack\n===============");

    //  Get the Length of the Stack
    int stackLength = playListMediaStack.GetTotalMedia;
    for(int i = 0; i < stackLength; i++)
    {
        sw.WriteLine($"Next: {playListMediaStack.ShowNextMedia()}");
        sw.WriteLine($"Play: {playListMediaStack.Play()}");
    }

    //  DON"T FORGET TO CLOSE, OR IT WON"T WRITE
    sw.Close();

    Console.WriteLine("Finished writing to file");
}
else
{
    Console.WriteLine($"File {readFrom} does not exists");
}