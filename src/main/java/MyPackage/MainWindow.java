package MyPackage;

import org.jfree.chart.ChartFactory;
import org.jfree.chart.ChartPanel;
import org.jfree.chart.JFreeChart;
import org.jfree.chart.plot.CategoryPlot;
import org.jfree.chart.plot.PlotOrientation;
import org.jfree.data.category.DefaultCategoryDataset;

import javax.imageio.ImageIO;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.net.URI;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.Month;
import java.time.format.DateTimeFormatter;
import java.util.Comparator;
import java.util.List;

enum Training {
    Dance,
    Cardio,
    Strength,
    MyConcept
}

enum dayOfWeek {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday;

}

public class MainWindow extends JFrame {
    private User user;
    private JPanel panelMain;
    private JTabbedPane userTabbedPane;
    private JPanel accountPanel;
    private JPanel trainingPanel;
    private JPanel progressPanel;
    private JLabel logoImgLabel;
    private JPanel homePanel;
    private JPanel paymentPanel;
    private JPanel coachFeedbackPanel;
    private JPanel trainingProgressPanel;
    private JButton signOutButton;
    private JPanel topPanel;
    private JTextArea newsTArea;
    private JLabel userNameLabel;
    private JPanel calendarJPanel;
    private JButton previousMonthButton;
    private JButton nextMonthButton;
    private JPanel navigateJPanel;
    private JLabel monthLabel;
    private JTable calendarTable;
    private DefaultTableModel calendarTableModel;
    private JScrollPane calendarScrollPane;
    private JTextArea danceTTextArea;
    private JTextArea trainingsTextArea;
    private JTextArea strengthTextArea;
    private JTextArea myConceptTextArea;
    private JButton joinDanceButton;
    private JLabel danceLabel;
    private JLabel cardioLabel;
    private JLabel strengthLabel;
    private JLabel myConceptLabel;
    private JButton joinCardioButton;
    private JButton joinStrengthButton;
    private JButton joinMyConceptButton;
    private JPanel coachPanel;
    private JLabel newsJLabel;
    private JScrollPane clientsJScrollPane;
    private JTable usersJTable;
    private DefaultTableModel usersTableModel;
    private JPanel clientsJPanel;
    private JPanel addTrainingJPanel;
    private JPanel chartJPanel;
    private JComboBox exercisesCBox;
    private JButton addExercise;
    private JSpinner amountOfExcercise;
    private JButton removeButton;
    private JButton createButton;
    private JSpinner amountOfExcercise2;
    private JComboBox exercisesCBox2;
    private JComboBox exercisesCBox3;
    private JComboBox exercisesCBox4;
    private JSpinner amountOfExcercise3;
    private JSpinner amountOfExcercise4;
    private JTextField titleTField;
    private JLabel errorLabel;
    private JButton documentationButton;
    private JButton coachDocButton;
    private JButton calendarDocButton;
    private JButton DanceDocNutton;
    private JButton CardDocNutton;
    private JButton strDocNutton;
    private JButton custDocNutton;
    private JButton joinTrainDocNutton;
    private JButton trainingDocButton;
    private JButton progDocButton;
    private JButton payDocButton;
    private JButton feedbackDocButton;
    private JButton TrainProgDocButton;
    private JButton createTrainDocButton;
    private JButton ChartDocBut;
    private JFreeChart chart;
    private CategoryPlot plot;
    private ChartPanel chPanel;
    private DefaultCategoryDataset dataset;
    private int month, year;
    private int exerciseNumber = 0;
    private static final String TRAINING = " Training";
    private final String [] userHeader = { "Training", "Coach", "Start Time", "End Time"};
    private final String [] coachHeader = { "Training", "Clients", "Start Time", "End Time"};

    public void updateUserNameLabel() {
        String updatedText;
        updatedText = "Hello " + getUser().getUsername()
                + " it's good time for training!";
        getUserNameLabel().setText(updatedText);
    }



    public MainWindow() {
        setContentPane(getPanelMain());
        setTitle("MyFitness");
        setLocation(102, 40);
        setSize(1176, 640);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        hideCoachPanel();
        BufferedImage img = null;
        try {
            img = ImageIO.read(new File("src/main/resources/image/myfitness-logo-without-background.png"));
        } catch (IOException e) {
            e.printStackTrace();
        }
        Image dimg = img.getScaledInstance(234, 65, Image.SCALE_SMOOTH);
        ImageIcon logoIcon = new ImageIcon(dimg);
        logoImgLabel.setIcon(logoIcon);

        calendarTableModel = new DefaultTableModel();
        calendarTableModel.setColumnIdentifiers(userHeader);
        calendarTable.setModel(calendarTableModel);
        usersTableModel = new DefaultTableModel();
        usersTableModel.setColumnIdentifiers(coachHeader);
        usersJTable.setModel(usersTableModel);

        addDiagram();

        signOutButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                getUserTabbedPane().setSelectedComponent(homePanel);
                hideCoachPanel();
                Controller.changeWindow(getMainFrame(),Controller.getLoginFrame());
            }
        });




        joinDanceButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Controller.showTrainingSignUp(Training.Dance.toString()+TRAINING,false);
            }
        });

        joinCardioButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Controller.showTrainingSignUp(Training.Cardio.toString()+TRAINING,false);
            }
        });

        joinStrengthButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Controller.showTrainingSignUp(Training.Strength.toString()+TRAINING,false);
            }
        });

        joinMyConceptButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Controller.showTrainingSignUp(Training.MyConcept.toString()+TRAINING,true);

            }
        });
        addExercise.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(exerciseNumber>=3){
                    return;
                }
                exerciseNumber++;
                getComboBox(exerciseNumber).setVisible(true);
                getSpinner(exerciseNumber).setVisible(true);
            }
        });
        removeButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(exerciseNumber<=0){
                    return;
                }
                getComboBox(exerciseNumber).setVisible(false);
                getSpinner(exerciseNumber).setVisible(false);
                exerciseNumber--;
            }
        });
        createButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(PasswordDB.textFieldIsEmpty(titleTField)){
                    getErrorLabel().setIcon(new ImageIcon("src/main/resources/image/without_bg_" +
                            "exclamation_mark_30x30.png"));
                    getErrorLabel().setText("You leave the Name of Training empty!");
                    getErrorLabel().setVisible(true);
                    return;
                }

                StringBuffer training = new StringBuffer();

                for (int i = 0; i <= exerciseNumber; i++) {
                    training.append(getComboBox(i).getSelectedItem());
                    training.append(", " + getSpinner(i).getValue()+ ";\n");
                }

                user.getCoachTrainings().put(titleTField.getText(),training);
            }
        });

        KeyStroke keyStroke = KeyStroke.getKeyStroke(KeyEvent.VK_F1, 0);
        Action helpAction = new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        };
        getPanelMain().getInputMap(JComponent.WHEN_IN_FOCUSED_WINDOW).put(keyStroke, "help");
        getPanelMain().getActionMap().put("help", helpAction);
        documentationButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic6.html#%D0%93%D0%BE%D0%BB%D0%BE%D0%B2%D0%BD%D0%B5_%D0%92%D1%96%D0%BA%D0%BD%D0%BE"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
        coachDocButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic9.html#%D0%90%D0%BA%D0%B0%D1%83%D0%BD%D1%82_%D1%82%D1%80%D0%B5%D0%BD%D0%B5%D1%80%D0%B0"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
        calendarDocButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic4.html#User_Account"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
        trainingDocButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic11.html#User_Training"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
        DanceDocNutton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#Dance_training"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
        CardDocNutton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#Cardio"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
        strDocNutton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#Strength"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
        custDocNutton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#MyConcept"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
        ActionListener listener = new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic4.html#In_progres"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        };
        progDocButton.addActionListener(listener);
        payDocButton.addActionListener(listener);
        feedbackDocButton.addActionListener(listener);
        TrainProgDocButton.addActionListener(listener);
        createTrainDocButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic7.html#%D0%97%D0%B0%D0%BF%D0%B8%D1%81_%D0%BD%D0%B0_%D1%82%D1%80%D0%B5%D0%BD%D1%83%D0%B2%D0%B0%D0%BD%D0%BD%D1%8F"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
        ChartDocBut.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    Desktop.getDesktop().browse(new URI("http://localhost:8080/Newtopic2.html#Client_ordinat"));
                } catch (Exception ex) {
                    ex.printStackTrace();
                }
            }
        });
    }

    public void showCoachPanel() {
        coachPanel.setName("For Coach");
        userTabbedPane.add(coachPanel);
    }

    public void hideCoachPanel() {
        userTabbedPane.remove(coachPanel);
    }

    public void restoreCalendar(){
        var userTrainings = sortCalendar();
        var users = sortUsers();
        getCalendarTableModel().setRowCount(0);
        for (var training: userTrainings){
            getCalendarTableModel().addRow(new Object[]{training.getTraining(), training.getPerson(),
                    training.getStartTime(), training.getEndTime()});
        }
        if(user.isCoach()){
            getUsersTableModel().setRowCount(0);
            for (var training: users){
                getUsersTableModel().addRow(new Object[]{training.getTraining(), training.getPerson(),
                        training.getStartTime(), training.getEndTime()});
            }
        }
    }

    private List<ScheduledTraining> sortCalendar(){
        return user.getScheduledTrainings().stream()
                .sorted(Comparator.comparing(ScheduledTraining::getDate))
                .toList();
    }

    private List<ScheduledTraining> sortUsers(){
        return user.getUserTrainings().stream()
                .sorted(Comparator.comparing(ScheduledTraining::getTraining))
                .sorted(Comparator.comparing(ScheduledTraining::getDate))
                .toList();
    }

    public void addRow(String training, String coach, String date, String startTime){
        User trainer = PasswordDB.getUser(coach);
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("h:mm a");
        LocalTime endTime = LocalTime.parse(startTime,formatter);
        endTime = endTime.plusHours(1);
        ScheduledTraining scheduledTraining = new ScheduledTraining(training, coach
                , date,date+" "+startTime,date+" "+endTime.format(formatter));

        user.addTraining(scheduledTraining);
        scheduledTraining.setPerson(user.getUsername());
        trainer.addUserTraining(scheduledTraining);
        getCalendarTableModel().addRow(new Object[]{training, coach, date+" "+startTime,date+" "+endTime.format(formatter)});
    }

    private void addDiagram(){
        dataset =  new DefaultCategoryDataset();

        for (dayOfWeek day : dayOfWeek.values()) {
            dataset.setValue(Long.valueOf(0), "Count", day.toString());
        }

        chart = ChartFactory.createBarChart("", "Day", "Clients", dataset, PlotOrientation.VERTICAL, false, true, false);

        plot = chart.getCategoryPlot();
        plot.setRangeGridlinePaint(Color.orange);
        plot.setBackgroundPaint(Color.WHITE);

        chPanel = new ChartPanel(chart); //creating the chart panel, which extends JPanel
        chPanel.setPreferredSize(new Dimension(482, 119));
        getChartJPanel().removeAll();
        getChartJPanel().add(chPanel);
    }

    public void addUserOnTraining(){
        var currentDate = LocalDate.now();
        LocalDate monday = currentDate.with(DayOfWeek.MONDAY);
        Month month = monday.getMonth();
        int dayOfMonth = monday.getDayOfMonth();
        StringBuffer date = new StringBuffer(month.toString() + " " + dayOfMonth);
        for (dayOfWeek day : dayOfWeek.values()) {
            dataset.setValue(countUserAtDay(date), "Count", day.toString());
            dayOfMonth++;
            date = new StringBuffer(month.toString() + " " + dayOfMonth);
        }
    }

    private Long countUserAtDay(StringBuffer date){
        return user.getUserTrainings().stream()
                .map(ScheduledTraining::getDate)
                .filter(d->d.equals(date.toString()))
                .count();
    }
    private JComboBox getComboBox(int i){
        if(i==0){
            return exercisesCBox;
        }else if(i==1){
            return exercisesCBox2;
        }else if(i==2){
            return exercisesCBox3;
        }else if(i==3){
            return exercisesCBox4;
        }
        else{
            return null;
        }
    }

    private JSpinner getSpinner(int i){
        if(i==0){
            return amountOfExcercise;
        }else if(i==1){
            return amountOfExcercise2;
        }else if(i==2){
            return amountOfExcercise3;
        }else if(i==3){
            return amountOfExcercise4;
        }
        else{
            return null;
        }
    }

    public MainWindow getMainFrame(){
        return this;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    public JPanel getPanelMain() {
        return panelMain;
    }

    public void setPanelMain(JPanel panelMain) {
        this.panelMain = panelMain;
    }

    public JTabbedPane getUserTabbedPane() {
        return userTabbedPane;
    }

    public void setUserTabbedPane(JTabbedPane userTabbedPane) {
        this.userTabbedPane = userTabbedPane;
    }

    public JPanel getAccountPanel() {
        return accountPanel;
    }

    public void setAccountPanel(JPanel accountPanel) {
        this.accountPanel = accountPanel;
    }

    public JPanel getTrainingPanel() {
        return trainingPanel;
    }

    public void setTrainingPanel(JPanel trainingPanel) {
        this.trainingPanel = trainingPanel;
    }

    public JPanel getProgressPanel() {
        return progressPanel;
    }

    public void setProgressPanel(JPanel progressPanel) {
        this.progressPanel = progressPanel;
    }

    public JLabel getLogoImgLabel() {
        return logoImgLabel;
    }
    public void setLogoImgLabel(JLabel logoImgLabel) {
        this.logoImgLabel = logoImgLabel;
    }

    public JPanel getHomePanel() {
        return homePanel;
    }

    public void setHomePanel(JPanel homePanel) {
        this.homePanel = homePanel;
    }

    public JPanel getPaymentPanel() {
        return paymentPanel;
    }

    public void setPaymentPanel(JPanel paymentPanel) {
        this.paymentPanel = paymentPanel;
    }

    public JPanel getCoachFeedbackPanel() {
        return coachFeedbackPanel;
    }

    public void setCoachFeedbackPanel(JPanel coachFeedbackPanel) {
        this.coachFeedbackPanel = coachFeedbackPanel;
    }

    public JPanel getTrainingProgressPanel() {
        return trainingProgressPanel;
    }

    public void setTrainingProgressPanel(JPanel trainingProgressPanel) {
        this.trainingProgressPanel = trainingProgressPanel;
    }

    public JButton getSignOutButton() {
        return signOutButton;
    }

    public void setSignOutButton(JButton signOutButton) {
        this.signOutButton = signOutButton;
    }

    public JPanel getTopPanel() {
        return topPanel;
    }

    public void setTopPanel(JPanel topPanel) {
        this.topPanel = topPanel;
    }

    public JTextArea getNewsTArea() {
        return newsTArea;
    }

    public void setNewsTArea(JTextArea newsTArea) {
        this.newsTArea = newsTArea;
    }

    public JLabel getUserNameLabel() {
        return userNameLabel;
    }

    public void setUserNameLabel(JLabel userNameLabel) {
        this.userNameLabel = userNameLabel;
    }

    public JPanel getCalendarJPanel() {
        return calendarJPanel;
    }

    public void setCalendarJPanel(JPanel calendarJPanel) {
        this.calendarJPanel = calendarJPanel;
    }

    public JButton getPreviousMonthButton() {
        return previousMonthButton;
    }

    public void setPreviousMonthButton(JButton previousMonthButton) {
        this.previousMonthButton = previousMonthButton;
    }

    public JButton getNextMonthButton() {
        return nextMonthButton;
    }

    public void setNextMonthButton(JButton nextMonthButton) {
        this.nextMonthButton = nextMonthButton;
    }

    public JPanel getNavigateJPanel() {
        return navigateJPanel;
    }

    public void setNavigateJPanel(JPanel navigateJPanel) {
        this.navigateJPanel = navigateJPanel;
    }

    public JLabel getMonthLabel() {
        return monthLabel;
    }

    public void setMonthLabel(JLabel monthLabel) {
        this.monthLabel = monthLabel;
    }

    public DefaultTableModel getCalendarTableModel() {
        return calendarTableModel;
    }

    public void setCalendarTableModel(DefaultTableModel calendarTableModel) {
        this.calendarTableModel = calendarTableModel;
    }

    public JTable getCalendarTable() {
        return calendarTable;
    }

    public void setCalendarTable(JTable calendarTable) {
        this.calendarTable = calendarTable;
    }

    public JScrollPane getCalendarScrollPane() {
        return calendarScrollPane;
    }

    public void setCalendarScrollPane(JScrollPane calendarScrollPane) {
        this.calendarScrollPane = calendarScrollPane;
    }

    public JTextArea getDanceTTextArea() {
        return danceTTextArea;
    }

    public void setDanceTTextArea(JTextArea danceTTextArea) {
        this.danceTTextArea = danceTTextArea;
    }

    public JTextArea getTrainingsTextArea() {
        return trainingsTextArea;
    }

    public void setTrainingsTextArea(JTextArea trainingsTextArea) {
        this.trainingsTextArea = trainingsTextArea;
    }

    public JTextArea getStrengthTextArea() {
        return strengthTextArea;
    }

    public void setStrengthTextArea(JTextArea strengthTextArea) {
        this.strengthTextArea = strengthTextArea;
    }

    public JTextArea getMyConceptTextArea() {
        return myConceptTextArea;
    }

    public void setMyConceptTextArea(JTextArea myConceptTextArea) {
        this.myConceptTextArea = myConceptTextArea;
    }

    public JButton getJoinDanceButton() {
        return joinDanceButton;
    }

    public void setJoinDanceButton(JButton joinDanceButton) {
        this.joinDanceButton = joinDanceButton;
    }

    public JLabel getDanceLabel() {
        return danceLabel;
    }

    public void setDanceLabel(JLabel danceLabel) {
        this.danceLabel = danceLabel;
    }

    public JLabel getCardioLabel() {
        return cardioLabel;
    }

    public void setCardioLabel(JLabel cardioLabel) {
        this.cardioLabel = cardioLabel;
    }

    public JLabel getStrengthLabel() {
        return strengthLabel;
    }

    public void setStrengthLabel(JLabel strengthLabel) {
        this.strengthLabel = strengthLabel;
    }

    public JLabel getMyConceptLabel() {
        return myConceptLabel;
    }

    public void setMyConceptLabel(JLabel myConceptLabel) {
        this.myConceptLabel = myConceptLabel;
    }

    public JButton getJoinCardioButton() {
        return joinCardioButton;
    }

    public void setJoinCardioButton(JButton joinCardioButton) {
        this.joinCardioButton = joinCardioButton;
    }

    public JButton getJoinStrengthButton() {
        return joinStrengthButton;
    }

    public void setJoinStrengthButton(JButton joinStrengthButton) {
        this.joinStrengthButton = joinStrengthButton;
    }

    public JButton getJoinMyConceptButton() {
        return joinMyConceptButton;
    }

    public void setJoinMyConceptButton(JButton joinMyConceptButton) {
        this.joinMyConceptButton = joinMyConceptButton;
    }

    public JPanel getCoachPanel() {
        return coachPanel;
    }

    public void setCoachPanel(JPanel coachPanel) {
        this.coachPanel = coachPanel;
    }

    public JLabel getNewsJLabel() {
        return newsJLabel;
    }

    public void setNewsJLabel(JLabel newsJLabel) {
        this.newsJLabel = newsJLabel;
    }

    public JScrollPane getClientsJScrollPane() {
        return clientsJScrollPane;
    }

    public void setClientsJScrollPane(JScrollPane clientsJScrollPane) {
        this.clientsJScrollPane = clientsJScrollPane;
    }

    public JTable getUsersJTable() {
        return usersJTable;
    }

    public void setUsersJTable(JTable usersJTable) {
        this.usersJTable = usersJTable;
    }

    public JPanel getClientsJPanel() {
        return clientsJPanel;
    }

    public void setClientsJPanel(JPanel clientsJPanel) {
        this.clientsJPanel = clientsJPanel;
    }

    public int getMonth() {
        return month;
    }

    public void setMonth(int month) {
        this.month = month;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public static String getTRAINING() {
        return TRAINING;
    }

    public DefaultTableModel getUsersTableModel() {
        return usersTableModel;
    }

    public void setUsersTableModel(DefaultTableModel usersTableModel) {
        this.usersTableModel = usersTableModel;
    }

    public String[] getUserHeader() {
        return userHeader;
    }

    public String[] getCoachHeader() {
        return coachHeader;
    }

    public JPanel getAddTrainingJPanel() {
        return addTrainingJPanel;
    }

    public void setAddTrainingJPanel(JPanel addTrainingJPanel) {
        this.addTrainingJPanel = addTrainingJPanel;
    }

    public JPanel getChartJPanel() {
        return chartJPanel;
    }

    public void setChartJPanel(JPanel chartJPanel) {
        this.chartJPanel = chartJPanel;
    }

    public JComboBox getExercisesCBox() {
        return exercisesCBox;
    }

    public void setExercisesCBox(JComboBox exercisesCBox) {
        this.exercisesCBox = exercisesCBox;
    }

    public JButton getAddExercise() {
        return addExercise;
    }

    public void setAddExercise(JButton addExercise) {
        this.addExercise = addExercise;
    }

    public JSpinner getAmountOfExcercise() {
        return amountOfExcercise;
    }

    public void setAmountOfExcercise(JSpinner amountOfExcercise) {
        this.amountOfExcercise = amountOfExcercise;
    }

    public JButton getRemoveButton() {
        return removeButton;
    }

    public void setRemoveButton(JButton removeButton) {
        this.removeButton = removeButton;
    }

    public JButton getCreateButton() {
        return createButton;
    }

    public void setCreateButton(JButton createButton) {
        this.createButton = createButton;
    }

    public JSpinner getAmountOfExcercise2() {
        return amountOfExcercise2;
    }

    public void setAmountOfExcercise2(JSpinner amountOfExcercise2) {
        this.amountOfExcercise2 = amountOfExcercise2;
    }

    public JComboBox getExercisesCBox2() {
        return exercisesCBox2;
    }

    public void setExercisesCBox2(JComboBox exercisesCBox2) {
        this.exercisesCBox2 = exercisesCBox2;
    }

    public JComboBox getExercisesCBox3() {
        return exercisesCBox3;
    }

    public void setExercisesCBox3(JComboBox exercisesCBox3) {
        this.exercisesCBox3 = exercisesCBox3;
    }

    public JComboBox getExercisesCBox4() {
        return exercisesCBox4;
    }

    public void setExercisesCBox4(JComboBox exercisesCBox4) {
        this.exercisesCBox4 = exercisesCBox4;
    }

    public JSpinner getAmountOfExcercise3() {
        return amountOfExcercise3;
    }

    public void setAmountOfExcercise3(JSpinner amountOfExcercise3) {
        this.amountOfExcercise3 = amountOfExcercise3;
    }

    public JSpinner getAmountOfExcercise4() {
        return amountOfExcercise4;
    }

    public void setAmountOfExcercise4(JSpinner amountOfExcercise4) {
        this.amountOfExcercise4 = amountOfExcercise4;
    }

    public JTextField getTitleTField() {
        return titleTField;
    }

    public void setTitleTField(JTextField titleTField) {
        this.titleTField = titleTField;
    }

    public JFreeChart getChart() {
        return chart;
    }

    public void setChart(JFreeChart chart) {
        this.chart = chart;
    }

    public CategoryPlot getPlot() {
        return plot;
    }

    public void setPlot(CategoryPlot plot) {
        this.plot = plot;
    }

    public ChartPanel getChPanel() {
        return chPanel;
    }

    public void setChPanel(ChartPanel chPanel) {
        this.chPanel = chPanel;
    }

    public DefaultCategoryDataset getDataset() {
        return dataset;
    }

    public void setDataset(DefaultCategoryDataset dataset) {
        this.dataset = dataset;
    }

    public int getExerciseNumber() {
        return exerciseNumber;
    }

    public void setExerciseNumber(int exerciseNumber) {
        this.exerciseNumber = exerciseNumber;
    }

    public JLabel getErrorLabel() {
        return errorLabel;
    }

    public void setErrorLabel(JLabel errorLabel) {
        this.errorLabel = errorLabel;
    }
}
