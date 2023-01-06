# Asset-Management
Asset management systems provide the tools to perform the data collection, storage and presentation. The imaging sensor and positioning equipment data is synchronized and stored in a database. A post-processing asset detection step allows the detection of assets. This project has presented a survey of object recognition methods, applicable to the task of automatic asset detection in asset management systems, where assets may appear at any distance. This system is effective and accurate. It reduces manual stress, time and is cost effective too.

# Introduction
Company asset management is a significant and time-consuming activity in any corporation. Typically, they carry out this task manually. High-Definition video cameras are becoming easier to get, and asset management systems are using them to collect data. It would be helpful if we could utilise the extra pixel data that these types of cameras provide for things that appear further away. The asset detection phase of asset management systems is the study's project's primary focus. Users can carry out this asset detection manually or automatically, which improves the effectiveness of the entire system. Methods of object identification are a logical choice for automating asset discovery. Since these techniques can be trained to identify assets in the data that has been recorded. 

The advantages of modern technology give organizations the opportunity to manage their assets, identify needless spending, and develop the best plans for utilizing their existing and future investments. With all of these advantages in mind, we set asset management system implementation as a strategic aim.

# Existing System
The management of assets is frequently a challenging responsibility in any corporation. The majority of the time, checking and maintaining assets are done by hand. For the purpose of doing the asset check, trained individuals are used. The performance of a strategy generally declined as asset distance increased. This system is completely inaccurate,  labor-intensive and manual. Sometimes the asset may have been stolen, but it may not become apparent until the object is manually verified. As a result, it takes longer to discover the missing or stolen object. This system is ineffective and inaccurate.
Methods of object identification are a logical choice for automating asset detection. Since these techniques can be trained to identify assets in the data that has been recorded. The determination of sighting distances is one use of being able to locate assets at all distances.

# Proposed System
Systems for asset management give users the means to collect, store, and show data. Data from imaging sensors and positioning systems are synced and stored in a database. Asset detection is possible through a post-processing phase. This project has offered a survey of object identification techniques that can be used for asset management systems' automatic asset detection, where objects can appear from any angle. This system works well and is precise. It also saves money and time and reduces physical labor stress.

Features proposed:
1. Recognition of Scale-Invariant Objects In photos that have been recorded, objects that are farther away appear to be of a different size (or scale).

2. Recognition of Objects with Invariant Distance: We distinguish between scale-invariant and distance-invariant approaches because the former use specific information about the expected distance of an object, whereas the latter are only interested in size.

3. Active Vision: The solutions that have been previously discussed all work with fixed camera systems. Active vision techniques, on the other hand, use non-fixed camera systems to provide both near- and far-range object recognition.

# Tech Stack
1. TensorFlow Object Detection  
2. OpenCV
3. Pillow
4. Keras
5. ImageAI
6. RetinaNet

# Implementation Screenshots
- Landing Page

![Landing Page](https://user-images.githubusercontent.com/52947925/211083458-6a39a28e-67c7-4e26-a3cf-f4f03559bc13.png)

- Domain Interface

![Screenshot (59)](https://user-images.githubusercontent.com/52947925/211083710-1ff8bece-ba36-497d-bc4a-eb3524936d24.png)

![Screenshot (60)](https://user-images.githubusercontent.com/52947925/211083708-dd815361-53b0-48d9-b352-f477bfbdad58.png)

![Screenshot (61)](https://user-images.githubusercontent.com/52947925/211083705-ee394c62-1067-43c5-b8c4-6ac1b2530dce.png)

![Screenshot (62)](https://user-images.githubusercontent.com/52947925/211083704-f20bf058-d452-4eef-ae6a-919df7149ef7.png)

![Screenshot (63)](https://user-images.githubusercontent.com/52947925/211083702-8e4b17fd-9034-4e37-9aeb-91832e2b44fe.png)

- Database

![Screenshot (94)](https://user-images.githubusercontent.com/52947925/211084246-9bd2f46b-1f93-417e-a741-4d0722a505b4.png)

# Conclusion
RetinaNet and ImageAI, which are two highly effective image processing algorithms, are the image processing techniques used. The algorithm is designed to transform the provided image to a standard 256 X 256 resolution even when the input image is of lesser resolution.

The majority of computer and robot vision systems depend heavily on the capacity to detect objects. We are still far from achieving human-level performance, particularly in terms of open-world learning, despite the fact that many consumer electronics now include some existing techniques (for example, face detection for auto-focus in smartphones) or have them built into assistant driving technologies.It should be emphasized that despite its potential value, object detection has not been applied frequently in many fields. The requirement for object detection systems is becoming increasingly critical as mobile robots and generally autonomous machines (such as quad-copters, drones, and soon service robots) start to be used more frequently. Last but not least, we must take into account the fact that nanorobots and robots that explore environments not yet visited by humans, such as deep ocean regions or other planets, would require object detection systems. These systems will need to learn new item classes as they are encountered. A real-time, open-world learning capability will be essential under these circumstances.

# Future Scope
The virtual concierge functions as a kind of personal assistant for clients. Visitors can use this digital service before they arrive at the resort or while they are there to learn more about what the hotel has to offer, take 360-degree video tours, find nearby attractions and events, and learn about options for upgrades or additional packages to buy. This is where targeted upsell promotions that are rich in important information that will be helpful to travelers and can considerably improve their stay are located, as opposed to the website home page. The virtual concierge may be a piece of the website connected to the hotel PMS software through the hotel app, which is the best part of this situation. This would enable the construction of a special digital gateway for two-way communication between the hotel and its clients, as well as even more individualized service.

# Reference
- Forrest N. et al, SqueezeNet: AlexNet-level accuracy with 50x fewer parameters and <0.5MB model size  https://arxiv.org/abs/1602.07360  
- Kaiming H. et al, Deep Residual Learning for Image Recognition https://arxiv.org/abs/1512.03385 
- Bradski, Gary; Kaehler, Adrian (2008). Learning OpenCV: Computer vision with the OpenCV library. O'Reilly Media, Inc. p. 6.
- Pulli, Kari; Baksheev, Anatoly; Kornyakov, Kirill; Eruhimov, Victor (1 April 2012). "Realtime Computer Vision with OpenCV". https://dl.acm.org/doi/10.1145/2181796.2206309 
- ImageNet Classification with Deep ConvolutionalNeural Networks Alex Krizhevsky, Ilya Sutskever, Geoffrey E. Hinton https://papers.nips.cc/paper/4824-imagenet-classification-with-deep-convolutional-neuralnetworks.pdf


