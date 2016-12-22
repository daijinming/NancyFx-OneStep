using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using Nancy;


namespace WebModular.SimpleApp
{   
    [Serializable]
    public class HomeModule : NancyModule
    {

        public HomeModule()
        {   
                                                
            Get["/"] = x =>
            {

                var model = new { title = "《唐诗三百首》简介", body = "《唐诗三百首》是一部流传很广的唐诗选集。唐朝（618年~907年）二百九十年间，是中国诗歌发展的黄金时代，云蒸霞蔚，名家辈出，唐诗数量多达五万首。孙琴安《唐诗选本六百种提要·自序》指出，“唐诗选本经大量散佚，至今尚存三百余种。当中最流行而家传户晓的，要算《唐诗三百首》。”《唐诗三百首》选诗范围相当广泛，收录了77家诗，共310首，在数量以杜甫诗数多，有38首、王维诗29首、李白诗27首、李商隐诗22首。它是中小学生接触中国古典诗歌最好的入门书籍。" };

                return this.View["Home", model];
            };

                        
        }
        

    }
}