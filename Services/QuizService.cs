using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizApp.Models;

namespace QuizApp.Services
{
    /// <summary>
    /// Represents the Quiz Service class.
    /// </summary>
    public class QuizService
    {
        /// <summary>
        /// Represents the function to Get all the quizzes available on the platform
        /// </summary>
        public List<Quiz> GetQuizzes()
        {
            return new List<Quiz>
            {
                new Quiz
                {
                    Title = "General Knowledge",
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Text = "What is the capital of France?",
                            Options = new List<AnswerOption>
                            {
                                new AnswerOption { Text = "Berlin" },
                                new AnswerOption { Text = "Madrid" },
                                new AnswerOption { Text = "Paris" },
                                new AnswerOption { Text = "Lisbon" }
                            },
                            CorrectOptionIndex = 2,
                            ScoreWeight = 1
                        },
                        new Question
                        {
                            Text = "What is 2 + 2?",
                            Options = new List<AnswerOption>
                            {
                                new AnswerOption { Text = "3" },
                                new AnswerOption { Text = "4" },
                                new AnswerOption { Text = "5" },
                                new AnswerOption { Text = "6" }
                            },
                            CorrectOptionIndex = 1,
                            ScoreWeight = 1
                        }
                    }
                },

                 new Quiz
                {
                    Title = "C#",
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Text = "What is a namespace?",
                            Options = new List<AnswerOption>
                            {
                                new AnswerOption { Text = "Collection of classes" },
                                new AnswerOption { Text = "Hello World" },
                                new AnswerOption { Text = "A function" },
                                new AnswerOption { Text = "I don't know" }
                            },
                            CorrectOptionIndex = 2,
                            ScoreWeight = 1
                        },
                        new Question
                        {
                            Text = "What is 2 + 2?",
                            Options = new List<AnswerOption>
                            {
                                new AnswerOption { Text = "3" },
                                new AnswerOption { Text = "4" },
                                new AnswerOption { Text = "5" },
                                new AnswerOption { Text = "6" }
                            },
                            CorrectOptionIndex = 1,
                            ScoreWeight = 1
                        }
                    }
                }
            };
        }
    }
}
