    from imageai.Detection import ObjectDetection
    import os
    import mysql.connector
    import time
    while True :
        mydb = mysql.connector.connect(
          host="**.**.**.**",
          user="user",
          passwd="",
          database="digitalimage"
        )

        mycursor = mydb.cursor()
        sql = 'select * from Semaphore'
        mycursor.execute(sql)
        tbl= mycursor.fetchall()
        while tbl[0][1] is 1:
            mydb = mysql.connector.connect(
              host="**.**.**.**",
              user="user",
              passwd="",
              database="digitalimage"
            )
            mycursor = mydb.cursor()
            sql = 'select * from Semaphore'
            mycursor.execute(sql)
            tbl= mycursor.fetchall()
            print(tbl[0][1])
            time.sleep(5)

         image recognition part(very important red color)
            execution_path = os.getcwd()

        detector = ObjectDetection()
        detector.setModelTypeAsRetinaNet()
        detector.setModelPath( os.path.join(execution_path , "resnet50_coco_best_v2.0.1.h5"))
        detector.loadModel()
        detections = detector.detectObjectsFromImage(input_image=os.path.join(execution_path , "image.jpg"), output_image_path=os.path.join(execution_path , "imagenew.jpg"))


        item =[];

        for eachObject in detections:
            print(eachObject["name"] , " : " , eachObject["percentage_probability"] )
            item.append(eachObject["name"])

        for i in item:
            sql = "INSERT INTO Asset (Item_Name) VALUES (\'%s\')"%(i)
            print(sql)
            mycursor.execute(sql)

        mydb.commit()

        print(mycursor.rowcount, "record inserted.")


        mydb1 = mysql.connector.connect(
              host="**.**.**.**",
              user="user",
              passwd="",
              database="digitalimage"
            )
        mycursor1 = mydb1.cursor()
        sql1='update Semaphore set test=1'
        mycursor1.execute(sql1)
        mydb1.commit()
        time.sleep(5)