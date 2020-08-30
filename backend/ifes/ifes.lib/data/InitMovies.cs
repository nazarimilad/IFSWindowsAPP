using System.Collections;
using System.Collections.Generic;
using ifes.lib.domain.Catalogs;
using ifes.lib.Enum;

namespace ifes.lib.data {
    public class InitMovies {
        public static List<Video> GetVideos() {
            var movies = new List<Video>
            {
                new Video()
                {
                    Description = "Best Movie Ever",
                    Rating = 70,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Shrek",
                    Price = 4.99,
                    ObjectStorageId = "ZackandMiriMakeaPorno_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Youth in Revolt",
                    Rating = 52,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Youth in Revolt",
                    Price = 4.99,
                    ObjectStorageId = "YouthinRevolt_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "You Will Meet a Tall Dark Stranger",
                    Rating = 35,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "You Will Meet a Tall Dark Stranger",
                    Price = 4.99,
                    ObjectStorageId = "YouWillMeetaTallDarkStranger_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "When in Rome",
                    Rating = 44,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "When in Rome",
                    Price = 4.99,
                    ObjectStorageId = "WheninRome_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "What Happens in Vegas",
                    Rating = 72,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "What Happens in Vegas",
                    Price = 4.99,
                    ObjectStorageId = "WhatHappensinVegas_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Water For Elephants",
                    Rating = 72,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Water For Elephants",
                    Price = 4.99,
                    ObjectStorageId = "WaterForElephants_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "WALL-E",
                    Rating = 89,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "WALL-E",
                    Price = 4.99,
                    ObjectStorageId = "WALL-E_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Waitress",
                    Rating = 67,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Waitress",
                    Price = 4.99,
                    ObjectStorageId = "Waitress_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Waiting For Forever",
                    Rating = 53,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Waiting For Forever",
                    Price = 4.99,
                    ObjectStorageId = "WaitingForForever_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Valentines Day",
                    Rating = 54,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Valentines Day",
                    Price = 4.99,
                    ObjectStorageId = "ValentinesDay_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Tyler Perrys Why Did I get Married",
                    Rating = 47,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Tyler Perrys Why Did I get Married",
                    Price = 4.99,
                    ObjectStorageId = "TylerPerrysWhyDidIgetMarried_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Twilight: Breaking Dawn",
                    Rating = 68,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Twilight: Breaking Dawn",
                    Price = 4.99,
                    ObjectStorageId = "Twilight:BreakingDawn_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Twilight",
                    Rating = 82,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Twilight",
                    Price = 4.99,
                    ObjectStorageId = "Twilight_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "The Ugly Truth",
                    Rating = 68,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "The Ugly Truth",
                    Price = 4.99,
                    ObjectStorageId = "TheUglyTruth_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "The Twilight Saga: New Moon",
                    Rating = 78,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "The Twilight Saga: New Moon",
                    Price = 4.99,
                    ObjectStorageId = "TheTwilightSaga:NewMoon_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "The Time Travelers Wife",
                    Rating = 65,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "The Time Travelers Wife",
                    Price = 4.99,
                    ObjectStorageId = "TheTimeTravelersWife_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "The Proposal",
                    Rating = 74,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "The Proposal",
                    Price = 4.99,
                    ObjectStorageId = "TheProposal_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "The Invention of Lying",
                    Rating = 47,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "The Invention of Lying",
                    Price = 4.99,
                    ObjectStorageId = "TheInventionofLying_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "The Heartbreak Kid",
                    Rating = 41,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "The Heartbreak Kid",
                    Price = 4.99,
                    ObjectStorageId = "TheHeartbreakKid_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "The Duchess",
                    Rating = 68,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "The Duchess",
                    Price = 4.99,
                    ObjectStorageId = "TheDuchess_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "The Curious Case of Benjamin Button",
                    Rating = 81,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "The Curious Case of Benjamin Button",
                    Price = 4.99,
                    ObjectStorageId = "TheCuriousCaseofBenjaminButton_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "The Back-up Plan",
                    Rating = 47,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "The Back-up Plan",
                    Price = 4.99,
                    ObjectStorageId = "TheBack-upPlan_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Tangled",
                    Rating = 88,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Tangled",
                    Price = 4.99,
                    ObjectStorageId = "Tangled_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Something Borrowed",
                    Rating = 48,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Something Borrowed",
                    Price = 4.99,
                    ObjectStorageId = "SomethingBorrowed_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Shes Out of My League",
                    Rating = 60,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Shes Out of My League",
                    Price = 4.99,
                    ObjectStorageId = "ShesOutofMyLeague_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Sex and the City Two",
                    Rating = 49,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Sex and the City Two",
                    Price = 4.99,
                    ObjectStorageId = "SexandtheCityTwo_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Sex and the City 2",
                    Rating = 49,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Sex and the City 2",
                    Price = 4.99,
                    ObjectStorageId = "SexandtheCity2_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Sex and the City",
                    Rating = 81,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Sex and the City",
                    Price = 4.99,
                    ObjectStorageId = "SexandtheCity_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Remember Me",
                    Rating = 70,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Remember Me",
                    Price = 4.99,
                    ObjectStorageId = "RememberMe_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Rachel Getting Married",
                    Rating = 61,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Rachel Getting Married",
                    Price = 4.99,
                    ObjectStorageId = "RachelGettingMarried_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Penelope",
                    Rating = 74,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Penelope",
                    Price = 4.99,
                    ObjectStorageId = "Penelope_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "P.S. I Love You",
                    Rating = 82,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "P.S. I Love You",
                    Price = 4.99,
                    ObjectStorageId = "P.S.ILoveYou_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Over Her Dead Body",
                    Rating = 47,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Over Her Dead Body",
                    Price = 4.99,
                    ObjectStorageId = "OverHerDeadBody_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Our Family Wedding",
                    Rating = 49,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Our Family Wedding",
                    Price = 4.99,
                    ObjectStorageId = "OurFamilyWedding_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "One Day",
                    Rating = 54,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "One Day",
                    Price = 4.99,
                    ObjectStorageId = "OneDay_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Not Easily Broken",
                    Rating = 66,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Not Easily Broken",
                    Price = 4.99,
                    ObjectStorageId = "NotEasilyBroken_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "No Reservations",
                    Rating = 64,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "No Reservations",
                    Price = 4.99,
                    ObjectStorageId = "NoReservations_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Nick and Norahs Infinite Playlist",
                    Rating = 67,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Nick and Norahs Infinite Playlist",
                    Price = 4.99,
                    ObjectStorageId = "NickandNorahsInfinitePlaylist_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "New Years Eve",
                    Rating = 48,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "New Years Eve",
                    Price = 4.99,
                    ObjectStorageId = "NewYearsEve_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "My Week with Marilyn",
                    Rating = 84,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "My Week with Marilyn",
                    Price = 4.99,
                    ObjectStorageId = "MyWeekwithMarilyn_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Music and Lyrics",
                    Rating = 70,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Music and Lyrics",
                    Price = 4.99,
                    ObjectStorageId = "MusicandLyrics_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Monte Carlo",
                    Rating = 50,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Monte Carlo",
                    Price = 4.99,
                    ObjectStorageId = "MonteCarlo_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Miss Pettigrew Lives for a Day",
                    Rating = 70,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Miss Pettigrew Lives for a Day",
                    Price = 4.99,
                    ObjectStorageId = "MissPettigrewLivesforaDay_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Midnight in Paris",
                    Rating = 84,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Midnight in Paris",
                    Price = 4.99,
                    ObjectStorageId = "MidnightinParis_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Marley and Me",
                    Rating = 77,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Marley and Me",
                    Price = 4.99,
                    ObjectStorageId = "MarleyandMe_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Mamma Mia!",
                    Rating = 76,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Mamma Mia!",
                    Price = 4.99,
                    ObjectStorageId = "MammaMia!_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Mamma Mia!",
                    Rating = 76,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Mamma Mia!",
                    Price = 4.99,
                    ObjectStorageId = "MammaMia!_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Made of Honor",
                    Rating = 61,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Made of Honor",
                    Price = 4.99,
                    ObjectStorageId = "MadeofHonor_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Love Happens",
                    Rating = 40,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Love Happens",
                    Price = 4.99,
                    ObjectStorageId = "LoveHappens_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Love & Other Drugs",
                    Rating = 55,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Love & Other Drugs",
                    Price = 4.99,
                    ObjectStorageId = "Love&OtherDrugs_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Life as We Know It",
                    Rating = 62,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Life as We Know It",
                    Price = 4.99,
                    ObjectStorageId = "LifeasWeKnowIt_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "License to Wed",
                    Rating = 55,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "License to Wed",
                    Price = 4.99,
                    ObjectStorageId = "LicensetoWed_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Letters to Juliet",
                    Rating = 62,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Letters to Juliet",
                    Price = 4.99,
                    ObjectStorageId = "LetterstoJuliet_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Leap Year",
                    Rating = 49,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Leap Year",
                    Price = 4.99,
                    ObjectStorageId = "LeapYear_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Knocked Up",
                    Rating = 83,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Knocked Up",
                    Price = 4.99,
                    ObjectStorageId = "KnockedUp_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Killers",
                    Rating = 45,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Killers",
                    Price = 4.99,
                    ObjectStorageId = "Killers_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Just Wright",
                    Rating = 58,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Just Wright",
                    Price = 4.99,
                    ObjectStorageId = "JustWright_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Jane Eyre",
                    Rating = 77,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Jane Eyre",
                    Price = 4.99,
                    ObjectStorageId = "JaneEyre_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Its Complicated",
                    Rating = 63,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Its Complicated",
                    Price = 4.99,
                    ObjectStorageId = "ItsComplicated_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "I Love You Phillip Morris",
                    Rating = 57,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "I Love You Phillip Morris",
                    Price = 4.99,
                    ObjectStorageId = "ILoveYouPhillipMorris_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "High School Musical 3: Senior Year",
                    Rating = 76,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "High School Musical 3: Senior Year",
                    Price = 4.99,
                    ObjectStorageId = "HighSchoolMusical3:SeniorYear_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Hes Just Not That Into You",
                    Rating = 60,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Hes Just Not That Into You",
                    Price = 4.99,
                    ObjectStorageId = "HesJustNotThatIntoYou_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Good Luck Chuck",
                    Rating = 61,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Good Luck Chuck",
                    Price = 4.99,
                    ObjectStorageId = "GoodLuckChuck_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Going the Distance",
                    Rating = 56,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Going the Distance",
                    Price = 4.99,
                    ObjectStorageId = "GoingtheDistance_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Gnomeo and Juliet",
                    Rating = 52,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Gnomeo and Juliet",
                    Price = 4.99,
                    ObjectStorageId = "GnomeoandJuliet_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Gnomeo and Juliet",
                    Rating = 52,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Gnomeo and Juliet",
                    Price = 4.99,
                    ObjectStorageId = "GnomeoandJuliet_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Ghosts of Girlfriends Past",
                    Rating = 47,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Ghosts of Girlfriends Past",
                    Price = 4.99,
                    ObjectStorageId = "GhostsofGirlfriendsPast_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Four Christmases",
                    Rating = 52,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Four Christmases",
                    Price = 4.99,
                    ObjectStorageId = "FourChristmases_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Fireproof",
                    Rating = 51,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Fireproof",
                    Price = 4.99,
                    ObjectStorageId = "Fireproof_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Enchanted",
                    Rating = 80,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Enchanted",
                    Price = 4.99,
                    ObjectStorageId = "Enchanted_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Dear John",
                    Rating = 66,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Dear John",
                    Price = 4.99,
                    ObjectStorageId = "DearJohn_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Beginners",
                    Rating = 80,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Beginners",
                    Price = 4.99,
                    ObjectStorageId = "Beginners_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "Across the Universe",
                    Rating = 84,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "Across the Universe",
                    Price = 4.99,
                    ObjectStorageId = "AcrosstheUniverse_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "A Serious Man",
                    Rating = 64,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "A Serious Man",
                    Price = 4.99,
                    ObjectStorageId = "ASeriousMan_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "A Dangerous Method",
                    Rating = 89,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "A Dangerous Method",
                    Price = 4.99,
                    ObjectStorageId = "ADangerousMethod_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "27 Dresses",
                    Rating = 71,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "27 Dresses",
                    Price = 4.99,
                    ObjectStorageId = "27Dresses_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                },
                new Video()
                {
                    Description = "(500) Days of Summer",
                    Rating = 81,
                    Discount = 0,
                    Duration = 90,
                    FileExtension = ".mkv",
                    Name = "(500) Days of Summer",
                    Price = 4.99,
                    ObjectStorageId = "(500)DaysofSummer_strg_id",
                    FileSize = 42069,
                    PaymentOption = PaymentOption.Card
                }
            };


            return movies;
        }
    }
}