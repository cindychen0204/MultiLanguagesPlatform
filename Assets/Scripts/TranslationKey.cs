﻿namespace MultiLanguageTK
{
    public class TranslationKey
    {
        public TranslationKey(Languages resource, Languages target, string input)
        {
            this.resource = resource;
            this.target = target;
            this.input = input;
        }
        public Languages resource;
        public Languages target;
        public string input;
    }
}