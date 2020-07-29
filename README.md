# Zombie-Tsunami-Core-Script-
## Lógica

<img src="https://github.com/EwertonLug/Zombie-Tsunami-Core-Script-/blob/master/Assets/Sprites/GitHub/logic.png" width="500" height="200">

A lógica implementada é parecida com a de um Multiplayer. 

Os players vão estar em uma lista e nessa lista apenas um player vai ser o master.

Os demais vão apenas seguir o master.

Se o master morrer passa para o próximo.

O master é sempre o elemento 0 da lista.

Os demais elementos vão sempre acompanhar o próximo da lista.

## Principais métodos
<i>FollowPivot</i> - Caso o player da lista não seja o master, vai apenas seguir o pivô.
pivô = [n-1], onde n é o index do player que não é master.

<i>UpdateMasterPlayer</i> - Toda vez que um player morre, esse método envia para os demais player o atual master na lista.

## ScreenShots

Exemplo 1

<img src="https://github.com/EwertonLug/Zombie-Tsunami-Core-Script-/blob/master/Assets/Sprites/GitHub/Screen1.png" width="720" height="400">

Exemplo 2

<img src="https://github.com/EwertonLug/Zombie-Tsunami-Core-Script-/blob/master/Assets/Sprites/GitHub/Screen2.png" width="720" height="400">

