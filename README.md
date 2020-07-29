# Zombie-Tsunami-Core-Script-
## Lógica
![Screenshot](https://github.com/EwertonLug/Zombie-Tsunami-Core-Script-/blob/master/Assets/Sprites/GitHub/logic.png)

A lógica implementada é parecida com a de um Multiplayer. 

Os players vão estar em uma lista e nessa lista apenas um player vai ser o master.

Os demais vão apenas seguir o master.

Se o master morrer passa para o próximo.

O master é sempre o elemento 0 da lista.

## Principais métodos
<i>FollowPivot</i> - Caso o player da lista não seja o master, vai apenas seguir o pivô.
pivô = [n-1], onde n é o index do player que não é master.

<i>UpdateMasterPlayer</i> - Toda vez que um player morre, esse método envia para os demais player o atual master na lista.

## ScreenShots

![Screenshot](https://github.com/EwertonLug/Zombie-Tsunami-Core-Script-/blob/master/Assets/Sprites/GitHub/Screen1.png)
![Screenshot](https://github.com/EwertonLug/Zombie-Tsunami-Core-Script-/blob/master/Assets/Sprites/GitHub/Screen2.png)

