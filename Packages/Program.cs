
using NAudio.Wave;

using (var audioFile = new AudioFileReader("Recording.m4a"))
using(var outputDevice = new WaveOutEvent())
{
    outputDevice.Init(audioFile);
    outputDevice.Play();

    Console.WriteLine("Audio is Playing... put your volume up");

    while (outputDevice.PlaybackState == PlaybackState.Playing)
    {
        Thread.Sleep(1000);
    }

    Console.WriteLine("Audio Finished Playing");
}