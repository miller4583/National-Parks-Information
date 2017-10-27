--INSERT park VALUES ('CVNP', 'Cuyahoga Valley National Park', 'Ohio', 32832, 696, 125, 0, 'Woodland', 2000, 2189849, 'Of all the paths you take in life, make sure a few of them are dirt.', 'John Muir', 'Though a short distance from the urban areas of Cleveland and Akron, Cuyahoga Valley National Park seems worlds away. The park is a refuge for native plants and wildlife, and provides routes of discovery for visitors. The winding Cuyahoga River gives way to deep forests, rolling hills, and open farmlands. Walk or ride the Towpath Trail to follow the historic route of the Ohio & Erie Canal', 0, 390)


INSERT park VALUES();


INSERT park VALUES('ANP', 'Acadia National Park', 'Maine', 49052, 1530, 120, 30, 'Coastal', 1916, 3303393, 'Wilderness itself is the basis of all our civilization. I wonder if we have enough reverence for life to concede to wilderness the right to live on', 'Margaret Murie','Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.', 25, 40 );
INSERT INTO weather VALUES ('ANP',1,30,47,'sunny');
INSERT INTO weather VALUES ('ANP',2,35,55,'sunny');
INSERT INTO weather VALUES ('ANP',3,34,50,'partly cloudy');
INSERT INTO weather VALUES ('ANP',4,33,47,'partly cloudy');
INSERT INTO weather VALUES ('ANP',5,30,43,'rain');


INSERT park VALUES('ASNP', 'American Samoa National Park', 'American Samoa', 8256, 1858, 25, 0, 'Island', 1988, 28892, 'The wilderness and the idea of wilderness is one of the permanent homes of the human spirit.', 'Joseph Wood Krutch' ,  'The southernmost national park is on three Samoan islands and protects coral reefs, rainforests, volcanic mountains, and white beaches. The area is also home to flying foxes, brown boobies, sea turtles, and 900 species of fish.', 20, 50);
INSERT INTO weather VALUES ('ASNP',1, 71,84,'thunderstorms');
INSERT INTO weather VALUES ('ASNP',2, 72,86,'thunderstorms');
INSERT INTO weather VALUES ('ASNP',3, 74,85,'partly cloudy');
INSERT INTO weather VALUES ('ASNP',4, 77,89,'thunderstorms');
INSERT INTO weather VALUES ('ASNP',5, 74,82,'thunderstorms');


INSERT park VALUES( 'ANP2', 'Arches National Park', 'Utah', 76678, 4085, 100, 51, 'Desert', 1971, 1585718, 'Standing there, gaping at this monstrous and inhumane spectacle of rock and cloud and sky and space, I feel a ridiculous greed and possessiveness come over me. I want to know it all, posess it all, embrace the entire scene intimately, deeply, totally.', 'Edward Abbey', 'This site features more than 2,000 natural sandstone arches, with some of the most popular arches in the park being Delicate Arch, Landscape Arch and Double Arch.[13] Millions of years of erosion have created these structures located in a desert climate where the arid ground has life-sustaining biological soil crusts and potholes that serve as natural water-collecting basins. Other geologic formations include stone pinnacles, fins, and balancing rocks.', 10, 273);
INSERT INTO weather VALUES ('ANP2',1, 34,65,'sunny');
INSERT INTO weather VALUES ('ANP2',2, 35,67,'sunny');
INSERT INTO weather VALUES ('ANP2',3, 37,65,'partly cloudy');
INSERT INTO weather VALUES ('ANP2',4, 34,62,'partly cloudy');
INSERT INTO weather VALUES ('ANP2',5, 35,64,'partly cloudy');



INSERT park VALUES('BNP', 'Badlands National Park', 'South Dakota', 242755, 2756, 18, 100, 'Prairie', 1978, 996263, 'Once a year, go someplace you’ve never been before.', 'Anonymous', 'The Badlands are a collection of buttes, pinnacles, spires, and mixed-grass prairies. The White River Badlands contain the largest assemblage of known late Eocene and Oligocene mammal fossils. The wildlife includes bison, bighorn sheep, black-footed ferrets, and prairie dogs.',25 , 234 );
INSERT INTO weather VALUES ('BNP',1, 26,47,'sunny');
INSERT INTO weather VALUES ('BNP',2, 30,53,'sunny');
INSERT INTO weather VALUES ('BNP',3, 28,55,'partly cloudy');
INSERT INTO weather VALUES ('BNP',4, 41,62,'partly cloudy');
INSERT INTO weather VALUES ('BNP',5, 47,64,'cloudy');

INSERT park VALUES('BBNP', 'Big Bend National Park', 'Texas', 801163, 1800, 100, 184, 'Desert', 1944, 388290, 'You are headed for wide open spaces. It is two hours to everything! Relax, take a tranquilizer, enjoy the landscape. It’s bigger than all outdoors. It is all outdoors! Get with the wilderness spirit!', 'LadyBird Johnson', 'Named for the prominent bend in the Rio Grande along the U.S.–Mexico border, this park encompasses a large and remote part of the Chihuahuan Desert. Its main attraction is backcountry recreation in the arid Chisos Mountains and in canyons along the river. A wide variety of Cretaceous and Tertiary fossils as well as cultural artifacts of Native Americans also exist within its borders.', 25 , 143);
INSERT INTO weather VALUES ('BBNP',1, 46,69,'sunny');
INSERT INTO weather VALUES ('BBNP',2, 48,75,'sunny');
INSERT INTO weather VALUES ('BBNP',3, 54,81,'partly cloudy');
INSERT INTO weather VALUES ('BBNP',4, 55,82,'sunny');
INSERT INTO weather VALUES ('BBNP',5, 58,83,'sunny');

DELETE from  weather where parkCode = 'ASNP';

select * from weather;
