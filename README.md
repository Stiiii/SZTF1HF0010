A mátrix mérete M × N-es, minden cellája egy (Ti) karaktert tartalmaz, bejárni pedig az alábbi
minta szerint kell, hogy megkapja az eredeti (T) üzenetet (S az elsőnek, E az utolsónak kiolvasandó
karakter helye, az olvasás haladási irányát a nyilak jelölik):

peldául, ha M=4, N=6              például, ha M=3, N=9                    például, ha M=7, N=5
→→→→→↓                             →→→→→→→→↓                                       →→→→↓
↑→→→↓↓                             ↑→→→→→→E↓                                       ↑→→↓↓
↑↑E←←↓                             S↑←←←←←←←                                       ↑↑E↓↓
S↑←←←←                                                                             ↑↑↑↓↓
                                                                                   ↑↑↑↓↓
                                                                                   ↑↑↑←↓
                                                                                   S↑←←←
                                                                                   
A mátrixban mindig a bal alsó sarokból kell indulnia és körkörösen befele haladva kell kiolvasni a
karaktereket, míg nem ér eli az utolsó karaktert (melynek pontos helye a mátrix méretétől függ).
Vagyis a bal alsó sarokból felfelé kell menni egészen a mátrix tetejéig, ahonnan jobbra kell tovább
haladni a mátrix jobb széléig, amit követően az aljáig lefelé kell kiolvasni a karaktereket. Ezután
egészen a kezdőpont előtti karakterig kell haladni majd felfelé és így tovább egyre beljebb a mátrixban.
[SZTF1HF0010.pdf](https://github.com/Stiiii/W92MEN_SZTF1HF0010/files/7409474/SZTF1HF0010.pdf)
