﻿using NewsAggregator.BackgroundWorkers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.BackgroundWorkers
{
    public interface INewsDatabase
    {
        void PrepareDB();

        void InsertArticle(Article article);
        void InsertArticles(List<Article> articles);
        List<Article> GetArticles(string topic, DateTime from, DateTime to);
        List<Article> GetArticles(DateTime from, DateTime to);

        void SaveCurrentWordsForHistory(); //Save the "GetCurrentWords" to the "GetWords" //Only once a Day
        List<WordCountPair> GetWords(int count, DateTime date);
        List<WordCountPair> GetWords(int count, string search);

        void UpdateCurrentWords();
        List<WordCountPair> GetCurrentWords(int count);

        List<DateCountPair> GetWordStatistic(DateTime from, DateTime to);
    }
}
