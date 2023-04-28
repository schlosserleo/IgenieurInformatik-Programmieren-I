f = open("applines.txt", "w")
rf = open("/home/leo/coding/Programmieren I/Uebungen/uebungsnamen.txt", "r")
i = 1
while (line := rf.readline()) != "":
    if (i % 2) != 0:
        description = f"Starte Übung {i // 2 + 1} - {line}"
        f.write("-" * (len(description.strip())) + "\n")
    else:
        description = f"Starte zusätzliche Übung {i // 2} - {line}"
        f.write("-" * (len(description.strip())) + "\n")
    i += 1
