using System;
using System.Collections.Generic;

namespace LinqLab0Angabe
{
    internal static class SampleData
    {
        internal static List<Album> GetSampleAlbums()
        {
            return new List<Album>
            {
                new Album { Id = 1, Title = "21", Artist = "Adele", Songs =
                    {
                        new Song { Id = 1, Title = "Rolling in the Deep", Performers = new string[] { "Paul Epworth", "Leo Taylor", "Noel Langley", "Neil Cowley", "Ray Carless", "Adele Laurie Blue Adkins" }, Rating = 4.85f, Duration = new TimeSpan(0, 03, 49), Year = 2011 },
                        new Song { Id = 2, Title = "Rumour Has It", Performers = new string[] { "Adele Laurie Blue Adkins" }, Rating = 3.5f, Duration = new TimeSpan(0, 03, 43), Year = 2011 },
                        new Song { Id = 3, Title = "Turning Tables", Performers = new string[] { "Adele Laurie Blue Adkins" }, Rating = 4f, Duration = new TimeSpan(0, 04, 10), Year = 2011 },
                        new Song { Id = 4, Title = "Don’t You Remember", Performers = new string[] { "Chris Dave", "David Campbell", "Smokey Hormel", "Matt Sweeney", "Pino Palladino", "Lenny Castro", "Adele Laurie Blue Adkins" }, Rating = 3.15f, Duration = new TimeSpan(0, 04, 03), Year = 2011 },
                        new Song { Id = 5, Title = "Set Fire to the Rain", Performers = new string[] { "Adele Laurie Blue Adkins" }, Rating = 4.1f, Duration = new TimeSpan(0, 04, 02), Year = 2011 },
                        new Song { Id = 6, Title = "He Won't Go", Performers = new string[] { "Chris Dave", "David Campbell", "Smokey Hormel", "Matt Sweeney", "Pino Palladino", "Lenny Castro", "Adele Laurie Blue Adkins" }, Rating = 2.75f, Duration = new TimeSpan(0, 04, 38), Year = 2011 },
                        new Song { Id = 7, Title = "Take It All", Performers = new string[] { "Adele Laurie Blue Adkins" }, Rating = 2.5f, Duration = new TimeSpan(0, 03, 48), Year = 2011 },
                        new Song { Id = 8, Title = "I’ll Be Waiting", Performers = new string[] { "Ben Thomas", "Paul Epworth", "Leo Taylor", "Adele Laurie Blue Adkins" }, Rating = 2.4f, Duration = new TimeSpan(0, 04, 02), Year = 2011 },
                        new Song { Id = 9, Title = "One and Only", Performers = new string[] { "Chris Dave", "David Campbell", "Smokey Hormel", "Matt Sweeney", "Pino Palladino", "Lenny Castro", "Adele Laurie Blue Adkins" }, Rating = 3.4f, Duration = new TimeSpan(0, 05, 48), Year = 2011 },
                        new Song { Id = 10, Title = "Lovesong", Performers = new string[] { "Chris Dave", "David Campbell", "Smokey Hormel", "Matt Sweeney", "Pino Palladino", "Lenny Castro", "Adele Laurie Blue Adkins" }, Rating = 3.3f, Duration = new TimeSpan(0, 05, 16), Year = 2011 },
                    }
                },
                new Album { Id = 2, Title = "The Sound of Music", Artist = "Soundtrack", Songs =
                    {
                        new Song { Id = 1, Title = "Prelude / The Sound of Music", Performers = new string[] { "Irwin Kostal", "Julie Andrews" }, Rating = 0f, Duration = new TimeSpan(0, 02, 44), Year = 1965 },
                        new Song { Id = 2, Title = "Overture / Preludium (Dixit Dominus)", Performers = new string[] { "Irwin Kostal", "Anna Lee", "Portia Nelson", "Marni Nixon", "Evadne Baker" }, Rating = 3f, Duration = new TimeSpan(0, 03, 13), Year = 2000 },
                        new Song { Id = 3, Title = "Morning Hymn / Alleluia", Performers = new string[] { "Anna Lee", "Portia Nelson", "Marni Nixon", "Evadne Baker" }, Rating = 3f, Duration = new TimeSpan(0, 02, 02), Year = 2000 },
                        new Song { Id = 4, Title = "Maria", Performers = new string[] { "Evadne Baker", "Anna Lee", "Portia Nelson", "Marni Nixon" }, Rating = 0f, Duration = new TimeSpan(0, 03, 17), Year = 2000 },
                        new Song { Id = 5, Title = "I Have Confidence", Performers = new string[] { "Julie Andrews" }, Rating = 3f, Duration = new TimeSpan(0, 03, 26), Year = 2000 },
                        new Song { Id = 6, Title = "Sixteen Going on Seventeen", Performers = new string[] { "Charmian Carr", "Dan Truhitte" }, Rating = 0f, Duration = new TimeSpan(0, 03, 17), Year = 2000 },
                        new Song { Id = 7, Title = "My Favorite Things", Performers = new string[] { "Julie Andrews" }, Rating = 0f, Duration = new TimeSpan(0, 02, 18), Year = 2000 },
                        new Song { Id = 8, Title = "Do-Re-Mi", Performers = new string[] { "Julie Andrews", "Charmian Carr", "Heather Menzies", "Nicholas Hammond", "Duane Chase", "Angela Cartwright", "Debbie Turner", "Kym Karath" }, Rating = 0f, Duration = new TimeSpan(0, 05, 33), Year = 2000 },
                        new Song { Id = 9, Title = "The Sound of Music", Performers = new string[] { "Charmian Carr", "Heather Menzies", "Nicholas Hammond", "Duane Chase", "Angela Cartwright", "Kym Karath", "Debbie Turner", "Bill Lee" }, Rating = 0f, Duration = new TimeSpan(0, 02, 10), Year = 2000 },
                        new Song { Id = 10, Title = "The Lonely Goatherd", Performers = new string[] { "Julie Andrews", "Charmian Carr", "Heather Menzies", "Nicholas Hammond", "Duane Chase", "Angela Cartwright", "Debbie Turner", "Kym Karath" }, Rating = 4f, Duration = new TimeSpan(0, 03, 10), Year = 2000 },
                        new Song { Id = 11, Title = "So Long, Farewell", Performers = new string[] { "Charmian Carr", "Heather Menzies", "Nicholas Hammond", "Duane Chase", "Angela Cartwright", "Debbie Turner", "Kym Karath" }, Rating = 0f, Duration = new TimeSpan(0, 02, 54), Year = 2000 },
                        new Song { Id = 12, Title = "Climb Ev’ry Mountain", Performers = new string[] { "Peggy Wood" }, Rating = 0f, Duration = new TimeSpan(0, 02, 16), Year = 2000 },
                        new Song { Id = 13, Title = "Something Good", Performers = new string[] { "Julie Andrews", "Bill Lee" }, Rating = 0f, Duration = new TimeSpan(0, 03, 17), Year = 1965 },
                        new Song { Id = 14, Title = "Processional and Maria", Performers = new string[] { "Evadne Baker", "Anna Lee", "Portia Nelson", "Marni Nixon" }, Rating = 0f, Duration = new TimeSpan(0, 02, 27), Year = 2000 },
                        new Song { Id = 15, Title = "Edelweiss (reprise)", Performers = new string[] { "Julie Andrews", "Bill Lee", "Charmian Carr", "Heather Menzies", "Nicholas Hammond", "Duane Chase", "Angela Cartwright", "Debbie Turner", "Kym Karath" }, Rating = 0f, Duration = new TimeSpan(0, 01, 50), Year = 2000 },
                        new Song { Id = 16, Title = "Climb Ev’ry Mountain (reprise)", Performers = new string[] { "Chorus", "Orchestra" }, Rating = 0f, Duration = new TimeSpan(0, 01, 21), Year = 2000 },
                    }
                },
                new Album { Id = 3, Title = "Thriller", Artist = "Michael Jackson", Songs =
                    {
                        new Song { Id = 1, Title = "Wanna Be Startin’ Somethin’", Performers = new string[] { "Michael Jackson" }, Rating = 4f, Duration = new TimeSpan(0, 06, 04), Year = 1982 },
                        new Song { Id = 2, Title = "Baby Be Mine", Performers = new string[] { "Michael Jackson" }, Rating = 3.65f, Duration = new TimeSpan(0, 04, 21), Year = 1982 },
                        new Song { Id = 3, Title = "The Girl Is Mine", Performers = new string[] { "Michael Jackson", "Paul McCartney" }, Rating = 3.3f, Duration = new TimeSpan(0, 03, 42), Year = 1982 },
                        new Song { Id = 4, Title = "Thriller", Performers = new string[] { "Michael Jackson" }, Rating = 4.7f, Duration = new TimeSpan(0, 05, 59), Year = 1982 },
                        new Song { Id = 5, Title = "Beat It", Performers = new string[] { "Michael Jackson" }, Rating = 4.45f, Duration = new TimeSpan(0, 04, 19), Year = 1982 },
                        new Song { Id = 6, Title = "Billie Jean", Performers = new string[] { "Michael Jackson" }, Rating = 4.45f, Duration = new TimeSpan(0, 04, 54), Year = 1982 },
                        new Song { Id = 7, Title = "Human Nature", Performers = new string[] { "Michael Jackson" }, Rating = 3.6f, Duration = new TimeSpan(0, 04, 06), Year = 1982 },
                        new Song { Id = 8, Title = "P.Y.T. (Pretty Young Thing)", Performers = new string[] { "Michael Jackson" }, Rating = 3.75f, Duration = new TimeSpan(0, 03, 59), Year = 1982 },
                        new Song { Id = 9, Title = "The Lady in My Life", Performers = new string[] { "Michael Jackson" }, Rating = 3f, Duration = new TimeSpan(0, 05, 00), Year = 1982 },
                    }
                },
                new Album { Id = 4, Title = "Fearless", Artist = "Taylor Swift", Songs =
                    {
                        new Song { Id = 1, Title = "Fearless", Performers = new string[] { "Taylor Swift" }, Rating = 4.35f, Duration = new TimeSpan(0, 04, 03), Year = 2009 },
                        new Song { Id = 2, Title = "Fifteen", Performers = new string[] { "Taylor Swift" }, Rating = 5f, Duration = new TimeSpan(0, 04, 55), Year = 2009 },
                        new Song { Id = 3, Title = "Love Story", Performers = new string[] { "Taylor Swift" }, Rating = 4.55f, Duration = new TimeSpan(0, 03, 55), Year = 2009 },
                        new Song { Id = 4, Title = "Hey Stephen", Performers = new string[] { "Taylor Swift" }, Rating = 4f, Duration = new TimeSpan(0, 04, 16), Year = 2009 },
                        new Song { Id = 5, Title = "White Horse", Performers = new string[] { "Taylor Swift" }, Rating = 4f, Duration = new TimeSpan(0, 03, 55), Year = 2009 },
                        new Song { Id = 6, Title = "You Belong With Me", Performers = new string[] { "Taylor Swift" }, Rating = 4f, Duration = new TimeSpan(0, 03, 52), Year = 2009 },
                        new Song { Id = 7, Title = "Breathe", Performers = new string[] { "Taylor Swift feat. Colbie Caillat" }, Rating = 3.65f, Duration = new TimeSpan(0, 04, 25), Year = 2009 },
                        new Song { Id = 8, Title = "Tell Me Why", Performers = new string[] { "Taylor Swift" }, Rating = 3f, Duration = new TimeSpan(0, 03, 22), Year = 2009 },
                        new Song { Id = 9, Title = "You’re Not Sorry", Performers = new string[] { "Taylor Swift" }, Rating = 3.35f, Duration = new TimeSpan(0, 04, 23), Year = 2009 },
                        new Song { Id = 10, Title = "The Way I Loved You", Performers = new string[] { "Taylor Swift" }, Rating = 3.35f, Duration = new TimeSpan(0, 04, 05), Year = 2009 },
                        new Song { Id = 11, Title = "Forever & Always", Performers = new string[] { "Taylor Swift" }, Rating = 4.65f, Duration = new TimeSpan(0, 03, 46), Year = 2009 },
                        new Song { Id = 12, Title = "The Best Day", Performers = new string[] { "Taylor Swift" }, Rating = 4f, Duration = new TimeSpan(0, 04, 06), Year = 2009 },
                        new Song { Id = 13, Title = "Change", Performers = new string[] { "Taylor Swift" }, Rating = 4f, Duration = new TimeSpan(0, 04, 40), Year = 2009 },
                        new Song { Id = 14, Title = "Our Song", Performers = new string[] { "Taylor Swift" }, Rating = 4.5f, Duration = new TimeSpan(0, 03, 21), Year = 2009 },
                        new Song { Id = 15, Title = "Teardrops on My Guitar", Performers = new string[] { "Taylor Swift" }, Rating = 5f, Duration = new TimeSpan(0, 03, 15), Year = 2009 },
                        new Song { Id = 16, Title = "Should’ve Said No", Performers = new string[] { "Taylor Swift" }, Rating = 4f, Duration = new TimeSpan(0, 04, 06), Year = 2009 },
                    }
                },
                new Album { Id = 5, Title = "Born In The U.S.A.", Artist = "Bruce Springsteen", Songs =
                    {
                        new Song { Id = 1, Title = "Born in the U.S.A.", Performers = new string[] { "Maurice Jarre" }, Rating = 3.5f, Duration = new TimeSpan(0, 04, 40), Year = 1984 },
                        new Song { Id = 2, Title = "Cover Me", Performers = new string[] { "Maurice Jarre" }, Rating = 3.35f, Duration = new TimeSpan(0, 03, 29), Year = 1984 },
                        new Song { Id = 3, Title = "Darlington County", Performers = new string[] { "Maurice Jarre" }, Rating = 3f, Duration = new TimeSpan(0, 04, 50), Year = 1984 },
                        new Song { Id = 4, Title = "Working on the Highway", Performers = new string[] { "Maurice Jarre" }, Rating = 2.35f, Duration = new TimeSpan(0, 03, 15), Year = 1984 },
                        new Song { Id = 5, Title = "Downbound Train", Performers = new string[] { "Maurice Jarre" }, Rating = 3.35f, Duration = new TimeSpan(0, 03, 38), Year = 1984 },
                        new Song { Id = 6, Title = "I’m on Fire", Performers = new string[] { "Maurice Jarre" }, Rating = 4f, Duration = new TimeSpan(0, 02, 42), Year = 1984 },
                        new Song { Id = 7, Title = "No Surrender", Performers = new string[] { "Maurice Jarre" }, Rating = 2.65f, Duration = new TimeSpan(0, 04, 03), Year = 1984 },
                        new Song { Id = 8, Title = "Bobby Jean", Performers = new string[] { "Maurice Jarre" }, Rating = 2.75f, Duration = new TimeSpan(0, 03, 48), Year = 1984 },
                        new Song { Id = 9, Title = "I’m Goin’ Down", Performers = new string[] { "Maurice Jarre" }, Rating = 3.35f, Duration = new TimeSpan(0, 03, 32), Year = 1984 },
                        new Song { Id = 10, Title = "Glory Days", Performers = new string[] { "Maurice Jarre" }, Rating = 4f, Duration = new TimeSpan(0, 04, 18), Year = 1984 },
                        new Song { Id = 11, Title = "Dancing in the Dark", Performers = new string[] { "Maurice Jarre" }, Rating = 4.45f, Duration = new TimeSpan(0, 04, 05), Year = 1984 },
                        new Song { Id = 12, Title = "My Hometown", Performers = new string[] { "Maurice Jarre" }, Rating = 3.35f, Duration = new TimeSpan(0, 04, 36), Year = 1984 },
                    }
                },
                new Album { Id = 6, Title = "Ropin' The Wind", Artist = "Garth Brooks", Songs =
                    {
                        new Song { Id = 1, Title = "Against the Grain", Performers = new string[] { "Garth Brooks" }, Rating = 0f, Duration = new TimeSpan(0, 02, 22), Year = 1991 },
                        new Song { Id = 2, Title = "Rodeo", Performers = new string[] { "Garth Brooks" }, Rating = 0f, Duration = new TimeSpan(0, 03, 54), Year = 1991 },
                        new Song { Id = 3, Title = "What She’s Doing Now", Performers = new string[] { "Garth Brooks" }, Rating = 4f, Duration = new TimeSpan(0, 03, 26), Year = 1991 },
                        new Song { Id = 4, Title = "Burning Bridges", Performers = new string[] { "Garth Brooks" }, Rating = 0f, Duration = new TimeSpan(0, 03, 36), Year = 1991 },
                        new Song { Id = 5, Title = "Papa Loved Mama", Performers = new string[] { "Garth Brooks" }, Rating = 0f, Duration = new TimeSpan(0, 02, 52), Year = 1991 },
                        new Song { Id = 6, Title = "Shameless", Performers = new string[] { "Garth Brooks" }, Rating = 0f, Duration = new TimeSpan(0, 04, 19), Year = 1991 },
                        new Song { Id = 7, Title = "Cold Shoulder", Performers = new string[] { "Garth Brooks" }, Rating = 0f, Duration = new TimeSpan(0, 03, 56), Year = 1991 },
                        new Song { Id = 8, Title = "We Bury the Hatchet", Performers = new string[] { "Garth Brooks" }, Rating = 0f, Duration = new TimeSpan(0, 03, 05), Year = 1991 },
                        new Song { Id = 9, Title = "In Lonesome Dove", Performers = new string[] { "Garth Brooks" }, Rating = 0f, Duration = new TimeSpan(0, 04, 49), Year = 1991 },
                        new Song { Id = 10, Title = "The River", Performers = new string[] { "Garth Brooks" }, Rating = 5f, Duration = new TimeSpan(0, 04, 26), Year = 1991 },
                    }
                },
                new Album { Id = 7, Title = "Jagged Little Pill", Artist = "Alanis Morissette", Songs =
                    {
                        new Song { Id = 1, Title = "All I Really Want", Performers = new string[] { "Alanis Morissette" }, Rating = 3.45f, Duration = new TimeSpan(0, 04, 45), Year = 1995 },
                        new Song { Id = 2, Title = "You Oughta Know", Performers = new string[] { "Alanis Morissette" }, Rating = 4f, Duration = new TimeSpan(0, 04, 09), Year = 1995 },
                        new Song { Id = 3, Title = "Perfect", Performers = new string[] { "Alanis Morissette" }, Rating = 3f, Duration = new TimeSpan(0, 03, 08), Year = 1995 },
                        new Song { Id = 4, Title = "Hand in My Pocket", Performers = new string[] { "Alanis Morissette" }, Rating = 4.15f, Duration = new TimeSpan(0, 03, 42), Year = 1995 },
                        new Song { Id = 5, Title = "Right Through You", Performers = new string[] { "Alanis Morissette" }, Rating = 3.3f, Duration = new TimeSpan(0, 02, 56), Year = 1995 },
                        new Song { Id = 6, Title = "Forgiven", Performers = new string[] { "Alanis Morissette" }, Rating = 3.3f, Duration = new TimeSpan(0, 05, 00), Year = 1995 },
                        new Song { Id = 7, Title = "You Learn", Performers = new string[] { "Alanis Morissette" }, Rating = 3.65f, Duration = new TimeSpan(0, 04, 00), Year = 1995 },
                        new Song { Id = 8, Title = "Head Over Feet", Performers = new string[] { "Alanis Morissette" }, Rating = 3.45f, Duration = new TimeSpan(0, 04, 27), Year = 1995 },
                        new Song { Id = 9, Title = "Mary Jane", Performers = new string[] { "Alanis Morissette" }, Rating = 3f, Duration = new TimeSpan(0, 04, 41), Year = 1995 },
                        new Song { Id = 10, Title = "Ironic", Performers = new string[] { "Alanis Morissette" }, Rating = 4.05f, Duration = new TimeSpan(0, 03, 50), Year = 1995 },
                        new Song { Id = 11, Title = "Not the Doctor", Performers = new string[] { "Alanis Morissette" }, Rating = 3f, Duration = new TimeSpan(0, 03, 48), Year = 1995 },
                        new Song { Id = 12, Title = "Wake Up / Your House", Performers = new string[] { "Alanis Morissette" }, Rating = 0f, Duration = new TimeSpan(0, 08, 53), Year = 1995 },
                    }
                },
                new Album { Id = 8, Title = "Doctor Zhivago", Artist = "Soundtrack", Songs =
                    {
                        new Song { Id = 1, Title = "Overture From \"Doctor Zhivago\"", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 04, 24), Year = 1965 },
                        new Song { Id = 2, Title = "Main Title From \"Doctor Zhivago\"", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 02, 42), Year = 1965 },
                        new Song { Id = 3, Title = "Lara Leaves Yuri", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 01, 29), Year = 1965 },
                        new Song { Id = 4, Title = "At the Student Cafe", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 01, 36), Year = 1965 },
                        new Song { Id = 5, Title = "Komarovsky and Lara's Rendezvous", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 03, 54), Year = 1965 },
                        new Song { Id = 6, Title = "Revolution", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 04, 05), Year = 1965 },
                        new Song { Id = 7, Title = "Lara's Theme From \"Doctor Zhivago\"", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 02, 54), Year = 1965 },
                        new Song { Id = 8, Title = "The Funeral", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 03, 09), Year = 1965 },
                        new Song { Id = 9, Title = "Sventytski's Waltz", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 02, 20), Year = 1965 },
                        new Song { Id = 10, Title = "Yuri Escapes", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 02, 21), Year = 1965 },
                        new Song { Id = 11, Title = "Tonya Arrives at Varykino", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 03, 52), Year = 1965 },
                        new Song { Id = 12, Title = "Yuri Writes a Poem for Lara", Performers = new string[] { "Maurice Jarre" }, Rating = 0f, Duration = new TimeSpan(0, 02, 48), Year = 1965 },
                    }
                },
                new Album { Id = 9, Title = "All The Right Reasons", Artist = "Nickelback", Songs =
                    {
                        new Song { Id = 1, Title = "Follow You Home", Performers = new string[] { "Nickelback" }, Rating = 3.5f, Duration = new TimeSpan(0, 04, 20), Year = 2005 },
                        new Song { Id = 2, Title = "Fight for All the Wrong Reasons", Performers = new string[] { "Nickelback" }, Rating = 3.35f, Duration = new TimeSpan(0, 03, 44), Year = 2005 },
                        new Song { Id = 3, Title = "Photograph", Performers = new string[] { "Nickelback" }, Rating = 4f, Duration = new TimeSpan(0, 04, 19), Year = 2005 },
                        new Song { Id = 4, Title = "Animals", Performers = new string[] { "Nickelback" }, Rating = 3.65f, Duration = new TimeSpan(0, 03, 07), Year = 2005 },
                        new Song { Id = 5, Title = "Savin’ Me", Performers = new string[] { "Nickelback" }, Rating = 3.5f, Duration = new TimeSpan(0, 03, 39), Year = 2005 },
                        new Song { Id = 6, Title = "Far Away", Performers = new string[] { "Nickelback" }, Rating = 3.65f, Duration = new TimeSpan(0, 03, 58), Year = 2005 },
                        new Song { Id = 7, Title = "Next Contestant", Performers = new string[] { "Nickelback" }, Rating = 3.35f, Duration = new TimeSpan(0, 03, 35), Year = 2005 },
                        new Song { Id = 8, Title = "Side of a Bullet", Performers = new string[] { "Nickelback" }, Rating = 3.35f, Duration = new TimeSpan(0, 03, 01), Year = 2005 },
                        new Song { Id = 9, Title = "If Everyone Cared", Performers = new string[] { "Nickelback" }, Rating = 3.2f, Duration = new TimeSpan(0, 03, 38), Year = 2005 },
                        new Song { Id = 10, Title = "Someone That You’re With", Performers = new string[] { "Nickelback" }, Rating = 3f, Duration = new TimeSpan(0, 04, 02), Year = 2005 },
                        new Song { Id = 11, Title = "Rockstar", Performers = new string[] { "Nickelback" }, Rating = 3.25f, Duration = new TimeSpan(0, 04, 19), Year = 2005 },
                        new Song { Id = 12, Title = "We Will Rock You", Performers = new string[] { "Nickelback" }, Rating = 0f, Duration = new TimeSpan(0, 02, 00), Year = 2005 },
                        new Song { Id = 13, Title = "Someday (acoustic live)", Performers = new string[] { "Nickelback" }, Rating = 4f, Duration = new TimeSpan(0, 03, 24), Year = 2005 },
                    }
                },
                new Album { Id = 10, Title = "Tapestry", Artist = "Carole King", Songs =
                    {
                        new Song { Id = 1, Title = "I Feel the Earth Move", Performers = new string[] { "Carole King" }, Rating = 2.5f, Duration = new TimeSpan(0, 03, 00), Year = 1986 },
                        new Song { Id = 2, Title = "So Far Away", Performers = new string[] { "Carole King" }, Rating = 3f, Duration = new TimeSpan(0, 03, 56), Year = 1986 },
                        new Song { Id = 3, Title = "It's Too Late", Performers = new string[] { "Carole King" }, Rating = 4f, Duration = new TimeSpan(0, 03, 54), Year = 1986 },
                        new Song { Id = 4, Title = "Home Again", Performers = new string[] { "Carole King" }, Rating = 0f, Duration = new TimeSpan(0, 02, 29), Year = 1986 },
                        new Song { Id = 5, Title = "Beautiful", Performers = new string[] { "Carole King" }, Rating = 0f, Duration = new TimeSpan(0, 03, 09), Year = 1986 },
                        new Song { Id = 6, Title = "Way Over Yonder", Performers = new string[] { "Carole King" }, Rating = 0f, Duration = new TimeSpan(0, 04, 49), Year = 1986 },
                        new Song { Id = 7, Title = "You've Got a Friend", Performers = new string[] { "Carole King" }, Rating = 4f, Duration = new TimeSpan(0, 05, 10), Year = 1986 },
                        new Song { Id = 8, Title = "Where You Lead", Performers = new string[] { "Carole King" }, Rating = 3.5f, Duration = new TimeSpan(0, 03, 20), Year = 1986 },
                        new Song { Id = 9, Title = "Will You Love Me Tomorrow?", Performers = new string[] { "Carole King" }, Rating = 0f, Duration = new TimeSpan(0, 04, 13), Year = 1986 },
                        new Song { Id = 10, Title = "Smackwater Jack", Performers = new string[] { "Carole King" }, Rating = 0f, Duration = new TimeSpan(0, 03, 43), Year = 1986 },
                        new Song { Id = 11, Title = "Tapestry", Performers = new string[] { "Carole King" }, Rating = 0f, Duration = new TimeSpan(0, 03, 16), Year = 1986 },
                        new Song { Id = 12, Title = "(You Make Me Feel Like) A Natural Woman", Performers = new string[] { "Carole King" }, Rating = 3f, Duration = new TimeSpan(0, 03, 49), Year = 1986 },
                    }
                },
                new Album { Id = 11, Title = "Whitney Houston", Artist = "Whitney Houston", Songs =
                    {
                        new Song { Id = 1, Title = "You Give Good Love", Performers = new string[] { "Whitney Houston" }, Rating = 4f, Duration = new TimeSpan(0, 04, 37), Year = 1985 },
                        new Song { Id = 2, Title = "Thinking About You", Performers = new string[] { "Whitney Houston" }, Rating = 4f, Duration = new TimeSpan(0, 05, 26), Year = 1985 },
                        new Song { Id = 3, Title = "Someone for Me", Performers = new string[] { "Whitney Houston" }, Rating = 4f, Duration = new TimeSpan(0, 05, 02), Year = 1985 },
                        new Song { Id = 4, Title = "Saving All My Love for You", Performers = new string[] { "Whitney Houston" }, Rating = 4f, Duration = new TimeSpan(0, 03, 59), Year = 1985 },
                        new Song { Id = 5, Title = "Nobody Loves Me Like You Do", Performers = new string[] { "Whitney Houston duet with Jermaine Jackson" }, Rating = 4f, Duration = new TimeSpan(0, 03, 49), Year = 1985 },
                        new Song { Id = 6, Title = "How Will I Know", Performers = new string[] { "Whitney Houston" }, Rating = 5f, Duration = new TimeSpan(0, 04, 37), Year = 1985 },
                        new Song { Id = 7, Title = "All at Once", Performers = new string[] { "Whitney Houston" }, Rating = 4f, Duration = new TimeSpan(0, 04, 30), Year = 1985 },
                        new Song { Id = 8, Title = "Take Good Care of My Heart", Performers = new string[] { "Whitney Houston duet with Jermaine Jackson" }, Rating = 4f, Duration = new TimeSpan(0, 04, 16), Year = 1985 },
                        new Song { Id = 9, Title = "Greatest Love of All", Performers = new string[] { "Whitney Houston" }, Rating = 5f, Duration = new TimeSpan(0, 04, 51), Year = 1985 },
                        new Song { Id = 10, Title = "Hold Me", Performers = new string[] { "Whitney Houston duet with Teddy Pendergrass" }, Rating = 4f, Duration = new TimeSpan(0, 06, 01), Year = 1985 },
                    }
                },
                new Album { Id = 12, Title = "The Fame", Artist = "Lady Gaga", Songs =
                    {
                        new Song { Id = 1, Title = "Just Dance", Performers = new string[] { "Lady Gaga feat. Colby O’Donis" }, Rating = 4.55f, Duration = new TimeSpan(0, 04, 02), Year = 2008 },
                        new Song { Id = 2, Title = "LoveGame", Performers = new string[] { "Lady Gaga" }, Rating = 4.15f, Duration = new TimeSpan(0, 03, 38), Year = 2008 },
                        new Song { Id = 3, Title = "Paparazzi", Performers = new string[] { "Lady Gaga" }, Rating = 4.65f, Duration = new TimeSpan(0, 03, 29), Year = 2008 },
                        new Song { Id = 4, Title = "Poker Face", Performers = new string[] { "Lady Gaga" }, Rating = 4.45f, Duration = new TimeSpan(0, 03, 59), Year = 2008 },
                        new Song { Id = 5, Title = "Eh, Eh (Nothing Else I Can Say)", Performers = new string[] { "Lady Gaga" }, Rating = 3.65f, Duration = new TimeSpan(0, 02, 57), Year = 2008 },
                        new Song { Id = 6, Title = "Beautiful, Dirty, Rich", Performers = new string[] { "Lady Gaga" }, Rating = 2.65f, Duration = new TimeSpan(0, 02, 53), Year = 2008 },
                        new Song { Id = 7, Title = "The Fame", Performers = new string[] { "Lady Gaga" }, Rating = 2.75f, Duration = new TimeSpan(0, 03, 43), Year = 2008 },
                        new Song { Id = 8, Title = "Money Honey", Performers = new string[] { "Lady Gaga" }, Rating = 3f, Duration = new TimeSpan(0, 02, 52), Year = 2008 },
                        new Song { Id = 9, Title = "Starstruck", Performers = new string[] { "Lady Gaga feat. Space Cowboy & Flo Rida" }, Rating = 4f, Duration = new TimeSpan(0, 03, 39), Year = 2008 },
                        new Song { Id = 10, Title = "Boys Boys Boys", Performers = new string[] { "Lady Gaga" }, Rating = 3.35f, Duration = new TimeSpan(0, 03, 22), Year = 2008 },
                        new Song { Id = 11, Title = "Paper Gangsta", Performers = new string[] { "Lady Gaga" }, Rating = 3.5f, Duration = new TimeSpan(0, 04, 25), Year = 2008 },
                        new Song { Id = 12, Title = "Brown Eyes", Performers = new string[] { "Lady Gaga" }, Rating = 2.75f, Duration = new TimeSpan(0, 04, 05), Year = 2008 },
                        new Song { Id = 13, Title = "I Like It Rough", Performers = new string[] { "Lady Gaga" }, Rating = 3.25f, Duration = new TimeSpan(0, 03, 24), Year = 2008 },
                        new Song { Id = 14, Title = "Summerboy", Performers = new string[] { "Lady Gaga" }, Rating = 2.35f, Duration = new TimeSpan(0, 04, 14), Year = 2008 },
                    }
                },
            };
        }
    }
}
