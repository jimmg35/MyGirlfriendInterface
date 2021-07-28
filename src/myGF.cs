

/*
*  請依照I女友介面去實作類別, 並依singleton方式注入至MyLife類別
*  實作流程請參照普遍臺灣女生實作
*  任何技術問題請洽: jimmg35
*  ##其餘加分項目不列入介面定義
*/


namespace MainMap {

   interface I女友介面 {
      public I元屬性 元屬性 {get; set;}
      public I頭部 頭部 {get; set;}
      public I手臂 手臂 {get; set;}
      public I上軀幹 上軀幹 {get; set;}
      public I下軀幹 下軀幹 {get; set;}
      public I個性 個性 {get; set;}
      public I價值觀 價值觀 {get; set;}
      public I生活模式 生活模式 {get; set;}
      public I不良習慣與特點 不良習慣與特點 {get; set;}
      public I外掛 外掛 {get; set;}
   }

}

namespace 人物外型 {

   interface I元屬性 {
      public 身形 中等偏肉(19<BMI<24);
      public 膚色 rgb(190, 142, 119)以上更淺都行;
      public 身高 最好170以下為佳(最多只能跟我一樣高178);
   }

   interface I頭部 {
      public 髮型 及肩短髮(可稍長);
      public 髮色 可接受染髮(通常是黑色);
      public 眉毛 隨意(不可一字眉);
      public 眼睛 其實都沒差(單眼皮為佳);
      public 鼻子 不喜歡鷹勾鼻(小鼻子可);
      private 嘴巴 嘴唇薄(偏好小嘴巴);
      public 下巴 不喜歡尖下巴(不行接受戽斗); 
   }

   interface I手臂 {
      public 寬度 至少別比我粗();
      public 手毛 不要多到太誇張都行();
   }

   interface I上軀幹 {
      public 胸部 A至C都行();
      public 肚子 不強迫要平坦(可以有贅肉);
   }

   interface I下軀幹 {
      public 腿長 短腿很可愛(其實不重要);
   }
}

namespace 人物內涵 {

   interface I個性 {
      public 談話 健談(至少得聽懂我的笑話);
      public 依賴性 低(需能獨立生存);
      public 吵架 不要用哭鬧解決(請理性);
      public 我很忙時 做自己的事(要有自己的生活重心);
   }
   
   interface I價值觀 {
      public 職涯 要有自己專精的領域();
      public 金錢 必須有經濟獨立的能力();
      public 約會 不用AA(男生是有多摳才要AA);
      public 組建家庭 必須將自身經濟能力顧好();
   }

   interface I生活模式 {
      public 睡覺 不可打呼磨牙(我很淺眠);
   }

   interface I不良習慣與特點 {
      public 喝酒 可接受();
      public 抽菸 可接受();
      public 刺青 可接受();
      public 穿耳環 可接受();
      public 裹小腳 都甚麼時代了(reject);
   }
}

namespace 外掛模組 {

   interface I外掛 {
      public 穿搭 此部分可自定義(但不可過於暴露);
      public 眼鏡 最好有戴眼鏡();
   }
}



