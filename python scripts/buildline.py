import os

dirname = os.path.dirname(__file__)
filename = os.path.join(dirname, '../bin/Debug/net7.0/applines.txt')
filename2 = os.path.join(dirname, '../bin/Debug/net7.0/uebungsnamen.txt')
f = open(filename, "w")
rf = open(filename2, "r")
i = 1
while (line := rf.readline()) != "":
    if (i % 2) != 0:
        description = f"Starte Übung {i // 2 + 1} - {line}"
        f.write("-" * (len(description.strip())) + "\n")
    else:
        description = f"Starte zusätzliche Übung {i // 2} - {line}"
        f.write("-" * (len(description.strip())) + "\n")
    i += 1
