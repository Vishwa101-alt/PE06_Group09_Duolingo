using FSDProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Configurations.Entities
{
    public class StoreItemSeed : IEntityTypeConfiguration<StoreItem>
    {
        public void Configure(EntityTypeBuilder<StoreItem> builder)
        {
            builder.HasData(
                new StoreItem
                {
                    StoreItemId = 1,
                    Questions = "How do you say 'How are you' in Hindi?",
                    MultipleChoice1 = "1. Kaise ho",
                    MultipleChoice2 = "2. Kaise hai",
                    MultipleChoice3 = "3. Aap kaise hai",
                    MultipleChoice4 = "4. Tum kaise ho",
                    Answer = 3,
                    CourseDatabaseId = 4

                },
                new StoreItem
                {
                    StoreItemId = 2,
                    Questions = "What does this sentence 'tum kis vishay mein ruchi rakhate ho? ' mean?",
                    MultipleChoice1 = "1. Which subject are you interested in?",
                    MultipleChoice2 = "2. Do you work?",
                    MultipleChoice3 = "3. What do you do for work?",
                    MultipleChoice4 = "4. Where do you study?",
                    Answer = 1,
                    CourseDatabaseId = 4
                },
                new StoreItem
                {
                    StoreItemId = 3,
                    Questions = "What should you say infront of your parents when you greet them in a informal tone",
                    MultipleChoice1 = "1. namaste maata-pita jee",
                    MultipleChoice2 = "2. suprabhaat, maan-paapa",
                    MultipleChoice3 = "3. kaise ho, maata-pita jee?",
                    MultipleChoice4 = "4. namaskaar, maata-pita!",
                    Answer = 2,
                    CourseDatabaseId = 4
                },
                new StoreItem
                {
                    StoreItemId = 4,
                    Questions = "'yah jagah kahaan hai?' means 'Where is this place?'. Is this true or false?",
                    MultipleChoice1 = "1. True",
                    MultipleChoice2 = "2. False",
                    MultipleChoice3 = "3. I don't know",
                    MultipleChoice4 = "4. Both",
                    Answer = 1,
                    CourseDatabaseId = 4
                },
                new StoreItem
                {
                    StoreItemId = 5,
                    Questions = "What does 'aapaka naam kya hai?' mean in English?",
                    MultipleChoice1 = "1. How old are you?",
                    MultipleChoice2 = "2. Where are you from?",
                    MultipleChoice3 = "3. What is your name?",
                    MultipleChoice4 = "4. What do you do?",
                    Answer = 3,
                    CourseDatabaseId = 4
                },
                new StoreItem
                {
                    StoreItemId = 6,
                    Questions = "Which sentence means 'I am fine'?",
                    MultipleChoice1 = "1. main achchha hoon",
                    MultipleChoice2 = "2. tum achchhe ho",
                    MultipleChoice3 = "3. ham achchhe hain",
                    MultipleChoice4 = "4. vah achchha hai",
                    Answer = 1,
                    CourseDatabaseId = 4
                },
                 new StoreItem
                 {
                     StoreItemId = 7,
                     Questions = "What is the Hindi word for 'book'?",
                     MultipleChoice1 = "1. kalam",
                     MultipleChoice2 = "2. pustak ",
                     MultipleChoice3 = "3. zameen",
                     MultipleChoice4 = "4. desk",
                     Answer = 2,
                     CourseDatabaseId = 4
                 },
                 new StoreItem
                 {
                     StoreItemId = 8,
                     Questions = "How do you say 'Good Night' in Hindi?",
                     MultipleChoice1 = "1. suprabhaat",
                     MultipleChoice2 = "2. shubh raatri",
                     MultipleChoice3 = "3. namaste",
                     MultipleChoice4 = "4. dhanyavaad",
                     Answer = 1,
                     CourseDatabaseId = 4
                 },
                //English
                new StoreItem
                {
                    StoreItemId = 9,
                    Questions = "Which word is a verb?",
                    MultipleChoice1 = "1. Run",
                    MultipleChoice2 = "2. Quickly",
                    MultipleChoice3 = "3. Beautiful",
                    MultipleChoice4 = "4. Happiness",
                    Answer = 1,
                    CourseDatabaseId = 1
                },
                new StoreItem
                {
                    StoreItemId = 10,
                    Questions = "Identify the adverb in this sentence: 'He runs very fast.'",
                    MultipleChoice1 = "1. He",
                    MultipleChoice2 = "2. Runs",
                    MultipleChoice3 = "3. Very",
                    MultipleChoice4 = "4. Fast",
                    Answer = 4,
                    CourseDatabaseId = 1
                },
                new StoreItem
                {
                    StoreItemId = 11,
                    Questions = "What is the past tense of 'go'?",
                    MultipleChoice1 = "1. Goes",
                    MultipleChoice2 = "2. Gone",
                    MultipleChoice3 = "3. Went",
                    MultipleChoice4 = "4. Going",
                    Answer = 3,
                    CourseDatabaseId = 1
                },
                new StoreItem
                {
                    StoreItemId = 12,
                    Questions = "Which sentence uses 'your' correctly?",
                    MultipleChoice1 = "1. Your going to the park",
                    MultipleChoice2 = "2. Your book is on the table",
                    MultipleChoice3 = "3. She asked your to help",
                    MultipleChoice4 = "4. Their book is here",
                    Answer = 2,
                    CourseDatabaseId = 1
                },
                new StoreItem
                {
                    StoreItemId = 13,
                    Questions = "Which word is a noun?",
                    MultipleChoice1 = "1. Run ",
                    MultipleChoice2 = "2. Beautiful ",
                    MultipleChoice3 = "3.Happiness ",
                    MultipleChoice4 = "4. Quickly ",
                    Answer = 3,
                    CourseDatabaseId = 1

                },
                new StoreItem
                {
                    StoreItemId = 14,
                    Questions = "Which word is an adjective?",
                    MultipleChoice1 = "1. Red",
                    MultipleChoice2 = "2. Jump",
                    MultipleChoice3 = "3. Apple",
                    MultipleChoice4 = "4. Slowly",
                    Answer = 1,
                    CourseDatabaseId = 1
                },
                new StoreItem
                {
                    StoreItemId = 15,
                    Questions = "Which sentence is grammatically correct?",
                    MultipleChoice1 = "1. She don’t like ice cream",
                    MultipleChoice2 = "2. He go to the park every morning",
                    MultipleChoice3 = "3. They are playing soccer in the field",
                    MultipleChoice4 = "4. The cat drinked all the milk",
                    Answer = 3,
                    CourseDatabaseId = 1
                },
                new StoreItem
                {
                    StoreItemId = 16,
                    Questions = "Which sentence uses 'their' correctly?",
                    MultipleChoice1 = "1. Their going to the park later today",
                    MultipleChoice2 = "2. The dog wagged their tail happily",
                    MultipleChoice3 = "3. She asked their to help with the project",
                    MultipleChoice4 = "4. The students finished their homework before class?",
                    Answer = 4,
                    CourseDatabaseId = 1
                },
                 //Malay
                 new StoreItem
                 {
                     StoreItemId = 17,
                     Questions = "What does 'Apa khabar' mean in English?",
                     MultipleChoice1 = "1. What is your name?",
                     MultipleChoice2 = "2. How are you?",
                     MultipleChoice3 = "3. Goodbye",
                     MultipleChoice4 = "4. Thank you",
                     Answer = 2,
                     CourseDatabaseId = 3
                 },
                new StoreItem
                {
                    StoreItemId = 18,
                    Questions = "Which Malay word means 'School'?",
                    MultipleChoice1 = "1. Rumah",
                    MultipleChoice2 = "2. Sekolah",
                    MultipleChoice3 = "3. Jalan",
                    MultipleChoice4 = "4. Buku",
                    Answer = 2,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 19,
                    Questions = "Translate 'Saya lapar' into English.",
                    MultipleChoice1 = "1. I am tired",
                    MultipleChoice2 = "2. I am hungry",
                    MultipleChoice3 = "3. I am happy",
                    MultipleChoice4 = "4. I am sad",
                    Answer = 2,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 20,
                    Questions = "How do you say 'Good evening' in Malay?",
                    MultipleChoice1 = "1. Selamat pagi",
                    MultipleChoice2 = "2. Selamat malam",
                    MultipleChoice3 = "3. Selamat petang",
                    MultipleChoice4 = "4. Selamat siang",
                    Answer = 3,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 21,
                    Questions = "What does the Malay word 'Selamat' mean?",
                    MultipleChoice1 = "1. Goodbye",
                    MultipleChoice2 = "2. Safe",
                    MultipleChoice3 = "3. Fast",
                    MultipleChoice4 = "4. Bright",
                    Answer = 2,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 22,
                    Questions = "What is the Malay word for 'Thank you'?",
                    MultipleChoice1 = "1. Selamat pagi",
                    MultipleChoice2 = "2. Apa khaba",
                    MultipleChoice3 = "3. Sama-sama",
                    MultipleChoice4 = "4. Terima kasih",
                    Answer = 4,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 23,
                    Questions = "Which malay sentence is correct when speaking to elders?",
                    MultipleChoice1 = "1. Apa khabar, kawan?",
                    MultipleChoice2 = "2. Saya nak pergi rumah awak",
                    MultipleChoice3 = "3. Eh, tolong bagi saya itu",
                    MultipleChoice4 = "4. Bolehkah saya bantu anda?",
                    Answer = 4,
                    CourseDatabaseId = 3
                },
                new StoreItem
                {
                    StoreItemId = 24,
                    Questions = "Does this sentence 'Saya suka makan nasi lemak di waktu pag' mean ' I like to eat nasi lemak in the morning'?",
                    MultipleChoice1 = "1. True",
                    MultipleChoice2 = "2. False",
                    MultipleChoice3 = "3. I dont know ",
                    MultipleChoice4 = "4. Both",
                    Answer = 1,
                    CourseDatabaseId = 3
                },
                //Burmese
                new StoreItem
                {
                    StoreItemId = 25,
                    Questions = "What does 'maung' mean in English?",
                    MultipleChoice1 = "1. Brother",
                    MultipleChoice2 = "2. Sister",
                    MultipleChoice3 = "3. Uncle",
                    MultipleChoice4 = "4. Aunt",
                    Answer = 1,
                    CourseDatabaseId = 2
                },
                new StoreItem
                {
                    StoreItemId = 26,
                    Questions = "Translate kyaayyjuutainpartaa' into English.",
                    MultipleChoice1 = "1. Welcome",
                    MultipleChoice2 = "2. Goodbye",
                    MultipleChoice3 = "3. Thank you",
                    MultipleChoice4 = "4. Excuse me",
                    Answer = 3,
                    CourseDatabaseId = 2
                },
                new StoreItem
                {
                    StoreItemId = 27,
                    Questions = "What is the Burmese word for 'School'?",
                    MultipleChoice1 = "1. nayaain",
                    MultipleChoice2 = "2. kyaungg",
                    MultipleChoice3 = "3. hcarr",
                    MultipleChoice4 = "4. ray",
                    Answer = 2,
                    CourseDatabaseId = 2
                },
                new StoreItem
                {
                    StoreItemId = 28,
                    Questions = "How do you say 'Goodbye' in Burmese?",
                    MultipleChoice1 = "1. hotekae",
                    MultipleChoice2 = "2. larpar",
                    MultipleChoice3 = "3. maingalarpar",
                    MultipleChoice4 = "4. swarrtotmaal",
                    Answer = 4,
                    CourseDatabaseId = 2
                },
                new StoreItem
                {
                    StoreItemId = 29,
                    Questions = "What is the Burmese word for 'water'?",
                    MultipleChoice1 = "1. Yay",
                    MultipleChoice2 = "2. Mee",
                    MultipleChoice3 = "3. Myay",
                    MultipleChoice4 = "4. Lay",
                    Answer = 1,
                    CourseDatabaseId = 2
                },
                new StoreItem
                {
                    StoreItemId = 30,
                    Questions = "What does 'maingalarpar' mean?",
                    MultipleChoice1 = "1.Goodbye",
                    MultipleChoice2 = "2. Hello",
                    MultipleChoice3 = "3. Thank you",
                    MultipleChoice4 = "4. Please",
                    Answer = 2,
                    CourseDatabaseId = 2
                },
                new StoreItem
                {
                    StoreItemId = 31,
                    Questions = "Which word is a Burmese noun?",
                    MultipleChoice1 = "1. Kyisu",
                    MultipleChoice2 = "2. Thwa",
                    MultipleChoice3 = "3. Lhpa",
                    MultipleChoice4 = "4. Kyaung",
                    Answer = 4,
                    CourseDatabaseId = 2
                },
                new StoreItem
                {
                    StoreItemId = 32,
                    Questions = "Which of the folowing is correct for Apple in Burmese?",
                    MultipleChoice1 = "1. paann",
                    MultipleChoice2 = "2. paannsee myarr",
                    MultipleChoice3 = "3. paannsee",
                    MultipleChoice4 = "4. see myarr",
                    Answer = 3,
                    CourseDatabaseId = 2
                }
            );
        }
    }
}
