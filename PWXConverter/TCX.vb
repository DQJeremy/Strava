Imports System.Xml.Serialization

'------------------------------------------------------------------------------
'THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
'FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
'DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
'ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
'------------------------------------------------------------------------------

Namespace TCX
    '''
    <System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2"), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", IsNullable:=False)> _
    Partial Public Class TrainingCenterDatabase
        Private foldersField As Folders_t
        Private activitiesField As ActivityList_t
        Private workoutsField() As Workout_t
        Private coursesField() As Course_t
        Private authorField As AbstractSource_t
        Private extensionsField As Extensions_t
        '''
        Public Property Folders() As Folders_t
            Get
                Return Me.foldersField
            End Get
            Set(value As Folders_t)
                Me.foldersField = value
            End Set
        End Property
        '''
        Public Property Activities() As ActivityList_t
            Get
                Return Me.activitiesField
            End Get
            Set(value As ActivityList_t)
                Me.activitiesField = value
            End Set
        End Property
        '''
        _
        Public Property Workouts() As Workout_t()
            Get
                Return Me.workoutsField
            End Get
            Set(value As Workout_t())
                Me.workoutsField = value
            End Set
        End Property
        '''
        _
        Public Property Courses() As Course_t()
            Get
                Return Me.coursesField
            End Get
            Set(value As Course_t())
                Me.coursesField = value
            End Set
        End Property
        '''
        Public Property Author() As AbstractSource_t
            Get
                Return Me.authorField
            End Get
            Set(value As AbstractSource_t)
                Me.authorField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Folders_t
        Private historyField As History_t
        Private workoutsField As Workouts_t
        Private coursesField As Courses_t
        '''
        Public Property History() As History_t
            Get
                Return Me.historyField
            End Get
            Set(value As History_t)
                Me.historyField = value
            End Set
        End Property
        '''
        Public Property Workouts() As Workouts_t
            Get
                Return Me.workoutsField
            End Get
            Set(value As Workouts_t)
                Me.workoutsField = value
            End Set
        End Property
        '''
        Public Property Courses() As Courses_t
            Get
                Return Me.coursesField
            End Get
            Set(value As Courses_t)
                Me.coursesField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class History_t
        Private runningField As HistoryFolder_t
        Private bikingField As HistoryFolder_t
        Private otherField As HistoryFolder_t
        Private multiSportField As MultiSportFolder_t
        Private extensionsField As Extensions_t
        '''
        Public Property Running() As HistoryFolder_t
            Get
                Return Me.runningField
            End Get
            Set(value As HistoryFolder_t)
                Me.runningField = value
            End Set
        End Property
        '''
        Public Property Biking() As HistoryFolder_t
            Get
                Return Me.bikingField
            End Get
            Set(value As HistoryFolder_t)
                Me.bikingField = value
            End Set
        End Property
        '''
        Public Property Other() As HistoryFolder_t
            Get
                Return Me.otherField
            End Get
            Set(value As HistoryFolder_t)
                Me.otherField = value
            End Set
        End Property
        '''
        Public Property MultiSport() As MultiSportFolder_t
            Get
                Return Me.multiSportField
            End Get
            Set(value As MultiSportFolder_t)
                Me.multiSportField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class HistoryFolder_t
        Private folderField() As HistoryFolder_t
        Private activityRefField() As ActivityReference_t
        Private weekField() As Week_t
        Private notesField As String
        Private extensionsField As Extensions_t
        Private nameField As String
        '''
        _
        Public Property Folder() As HistoryFolder_t()
            Get
                Return Me.folderField
            End Get
            Set(value As HistoryFolder_t())
                Me.folderField = value
            End Set
        End Property
        '''
        _
        Public Property ActivityRef() As ActivityReference_t()
            Get
                Return Me.activityRefField
            End Get
            Set(value As ActivityReference_t())
                Me.activityRefField = value
            End Set
        End Property
        '''
        _
        Public Property Week() As Week_t()
            Get
                Return Me.weekField
            End Get
            Set(value As Week_t())
                Me.weekField = value
            End Set
        End Property
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class ActivityReference_t
        Private idField As Date
        '''
        Public Property Id() As Date
            Get
                Return Me.idField
            End Get
            Set(value As Date)
                Me.idField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Week_t
        Private notesField As String
        Private startDayField As Date
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property StartDay() As Date
            Get
                Return Me.startDayField
            End Get
            Set(value As Date)
                Me.startDayField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Extensions_t
        Private anyField() As System.Xml.XmlElement
        '''
        _
        Public Property Any() As System.Xml.XmlElement()
            Get
                Return Me.anyField
            End Get
            Set(value As System.Xml.XmlElement())
                Me.anyField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class MultiSportFolder_t
        Private folderField() As MultiSportFolder_t
        Private multisportActivityRefField() As ActivityReference_t
        Private weekField() As Week_t
        Private notesField As String
        Private extensionsField As Extensions_t
        Private nameField As String
        '''
        _
        Public Property Folder() As MultiSportFolder_t()
            Get
                Return Me.folderField
            End Get
            Set(value As MultiSportFolder_t())
                Me.folderField = value
            End Set
        End Property
        '''
        _
        Public Property MultisportActivityRef() As ActivityReference_t()
            Get
                Return Me.multisportActivityRefField
            End Get
            Set(value As ActivityReference_t())
                Me.multisportActivityRefField = value
            End Set
        End Property
        '''
        _
        Public Property Week() As Week_t()
            Get
                Return Me.weekField
            End Get
            Set(value As Week_t())
                Me.weekField = value
            End Set
        End Property
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Workouts_t
        Private runningField As WorkoutFolder_t
        Private bikingField As WorkoutFolder_t
        Private otherField As WorkoutFolder_t
        Private extensionsField As Extensions_t
        '''
        Public Property Running() As WorkoutFolder_t
            Get
                Return Me.runningField
            End Get
            Set(value As WorkoutFolder_t)
                Me.runningField = value
            End Set
        End Property
        '''
        Public Property Biking() As WorkoutFolder_t
            Get
                Return Me.bikingField
            End Get
            Set(value As WorkoutFolder_t)
                Me.bikingField = value
            End Set
        End Property
        '''
        Public Property Other() As WorkoutFolder_t
            Get
                Return Me.otherField
            End Get
            Set(value As WorkoutFolder_t)
                Me.otherField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class WorkoutFolder_t
        Private folderField() As WorkoutFolder_t
        Private workoutNameRefField() As NameKeyReference_t
        Private extensionsField As Extensions_t
        Private nameField As String
        '''
        _
        Public Property Folder() As WorkoutFolder_t()
            Get
                Return Me.folderField
            End Get
            Set(value As WorkoutFolder_t())
                Me.folderField = value
            End Set
        End Property
        '''
        _
        Public Property WorkoutNameRef() As NameKeyReference_t()
            Get
                Return Me.workoutNameRefField
            End Get
            Set(value As NameKeyReference_t())
                Me.workoutNameRefField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class NameKeyReference_t
        Private idField As String
        '''
        _
        Public Property Id() As String
            Get
                Return Me.idField
            End Get
            Set(value As String)
                Me.idField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Courses_t
        Private courseFolderField As CourseFolder_t
        Private extensionsField As Extensions_t
        '''
        Public Property CourseFolder() As CourseFolder_t
            Get
                Return Me.courseFolderField
            End Get
            Set(value As CourseFolder_t)
                Me.courseFolderField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class CourseFolder_t
        Private folderField() As CourseFolder_t
        Private courseNameRefField() As NameKeyReference_t
        Private notesField As String
        Private extensionsField As Extensions_t
        Private nameField As String
        '''
        _
        Public Property Folder() As CourseFolder_t()
            Get
                Return Me.folderField
            End Get
            Set(value As CourseFolder_t())
                Me.folderField = value
            End Set
        End Property
        '''
        _
        Public Property CourseNameRef() As NameKeyReference_t()
            Get
                Return Me.courseNameRefField
            End Get
            Set(value As NameKeyReference_t())
                Me.courseNameRefField = value
            End Set
        End Property
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class ActivityList_t
        Private activityField() As Activity_t
        Private multiSportSessionField() As MultiSportSession_t
        '''
        <XmlElement()> _
        Public Property Activity() As Activity_t()
            Get
                Return Me.activityField
            End Get
            Set(value As Activity_t())
                Me.activityField = value
            End Set
        End Property
        '''
        <XmlElement()> _
        Public Property MultiSportSession() As MultiSportSession_t()
            Get
                Return Me.multiSportSessionField
            End Get
            Set(value As MultiSportSession_t())
                Me.multiSportSessionField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Activity_t
        Private idField As Date
        Private lapField() As ActivityLap_t
        Private notesField As String
        Private trainingField As Training_t
        Private creatorField As AbstractSource_t
        Private extensionsField As Extensions_t
        Private sportField As Sport_t
        '''
        Public Property Id() As Date
            Get
                Return Me.idField
            End Get
            Set(value As Date)
                Me.idField = value
            End Set
        End Property
        '''
        <XmlElement()> _
        Public Property Lap() As ActivityLap_t()
            Get
                Return Me.lapField
            End Get
            Set(value As ActivityLap_t())
                Me.lapField = value
            End Set
        End Property
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
        '''
        Public Property Training() As Training_t
            Get
                Return Me.trainingField
            End Get
            Set(value As Training_t)
                Me.trainingField = value
            End Set
        End Property
        '''
        Public Property Creator() As AbstractSource_t
            Get
                Return Me.creatorField
            End Get
            Set(value As AbstractSource_t)
                Me.creatorField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property Sport() As Sport_t
            Get
                Return Me.sportField
            End Get
            Set(value As Sport_t)
                Me.sportField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class ActivityLap_t
        Private totalTimeSecondsField As Double
        Private distanceMetersField As Double
        Private maximumSpeedField As Double
        Private maximumSpeedFieldSpecified As Boolean
        Private caloriesField As UShort
        Private averageHeartRateBpmField As HeartRateInBeatsPerMinute_t
        Private maximumHeartRateBpmField As HeartRateInBeatsPerMinute_t
        Private intensityField As Intensity_t
        Private cadenceField As Byte
        Private cadenceFieldSpecified As Boolean
        Private triggerMethodField As TriggerMethod_t
        Private trackField() As Track_t
        Private notesField As String
        Private extensionsField As Extensions_t
        Private startTimeField As Date
        '''
        Public Property TotalTimeSeconds() As Double
            Get
                Return Me.totalTimeSecondsField
            End Get
            Set(value As Double)
                Me.totalTimeSecondsField = value
            End Set
        End Property
        '''
        Public Property DistanceMeters() As Double
            Get
                Return Me.distanceMetersField
            End Get
            Set(value As Double)
                Me.distanceMetersField = value
            End Set
        End Property
        '''
        Public Property MaximumSpeed() As Double
            Get
                Return Me.maximumSpeedField
            End Get
            Set(value As Double)
                Me.maximumSpeedField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property MaximumSpeedSpecified() As Boolean
            Get
                Return Me.maximumSpeedFieldSpecified
            End Get
            Set(value As Boolean)
                Me.maximumSpeedFieldSpecified = value
            End Set
        End Property
        '''
        Public Property Calories() As UShort
            Get
                Return Me.caloriesField
            End Get
            Set(value As UShort)
                Me.caloriesField = value
            End Set
        End Property
        '''
        Public Property AverageHeartRateBpm() As HeartRateInBeatsPerMinute_t
            Get
                Return Me.averageHeartRateBpmField
            End Get
            Set(value As HeartRateInBeatsPerMinute_t)
                Me.averageHeartRateBpmField = value
            End Set
        End Property
        '''
        Public Property MaximumHeartRateBpm() As HeartRateInBeatsPerMinute_t
            Get
                Return Me.maximumHeartRateBpmField
            End Get
            Set(value As HeartRateInBeatsPerMinute_t)
                Me.maximumHeartRateBpmField = value
            End Set
        End Property
        '''
        Public Property Intensity() As Intensity_t
            Get
                Return Me.intensityField
            End Get
            Set(value As Intensity_t)
                Me.intensityField = value
            End Set
        End Property
        '''
        Public Property Cadence() As Byte
            Get
                Return Me.cadenceField
            End Get
            Set(value As Byte)
                Me.cadenceField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property CadenceSpecified() As Boolean
            Get
                Return Me.cadenceFieldSpecified
            End Get
            Set(value As Boolean)
                Me.cadenceFieldSpecified = value
            End Set
        End Property
        '''
        Public Property TriggerMethod() As TriggerMethod_t
            Get
                Return Me.triggerMethodField
            End Get
            Set(value As TriggerMethod_t)
                Me.triggerMethodField = value
            End Set
        End Property
        '''
        <XmlElement()> _
        Public Property Track() As Track_t()
            Get
                Return Me.trackField
            End Get
            Set(value As Track_t())
                Me.trackField = value
            End Set
        End Property
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property StartTime() As Date
            Get
                Return Me.startTimeField
            End Get
            Set(value As Date)
                Me.startTimeField = value
            End Set
        End Property

        <XmlIgnore()> _
        Public Property BeginningOffset As Double = 0
        <XmlIgnore()> _
        Public Property EndOffset As Double = 0

    End Class
    '''
     _
    Partial Public Class HeartRateInBeatsPerMinute_t
        Inherits HeartRateValue_t
        Private valueField As Byte
        '''
        Public Property Value() As Byte
            Get
                Return Me.valueField
            End Get
            Set(value As Byte)
                Me.valueField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public MustInherit Class HeartRateValue_t
    End Class
    '''
     _
    Public Enum Intensity_t
        '''
        Active
        '''
        Resting
    End Enum
    '''
     _
    Public Enum TriggerMethod_t
        '''
        Manual
        '''
        Distance
        '''
        Location
        '''
        Time
        '''
        HeartRate
    End Enum
    '''
     _
    Partial Public Class Trackpoint_t
        Private timeField As Date
        Private positionField As Position_t
        Private altitudeMetersField As Double
        Private altitudeMetersFieldSpecified As Boolean
        Private distanceMetersField As Double
        Private distanceMetersFieldSpecified As Boolean
        Private heartRateBpmField As HeartRateInBeatsPerMinute_t
        Private cadenceField As Byte
        Private cadenceFieldSpecified As Boolean
        Private sensorStateField As SensorState_t
        Private sensorStateFieldSpecified As Boolean
        Private extensionsField As Extensions_t
        '''
        Public Property Time() As Date
            Get
                Return Me.timeField
            End Get
            Set(value As Date)
                Me.timeField = value
            End Set
        End Property
        '''
        Public Property Position() As Position_t
            Get
                Return Me.positionField
            End Get
            Set(value As Position_t)
                Me.positionField = value
            End Set
        End Property
        '''
        Public Property AltitudeMeters() As Double
            Get
                Return Me.altitudeMetersField
            End Get
            Set(value As Double)
                Me.altitudeMetersField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property AltitudeMetersSpecified() As Boolean
            Get
                Return Me.altitudeMetersFieldSpecified
            End Get
            Set(value As Boolean)
                Me.altitudeMetersFieldSpecified = value
            End Set
        End Property
        '''
        Public Property DistanceMeters() As Double
            Get
                Return Me.distanceMetersField
            End Get
            Set(value As Double)
                Me.distanceMetersField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property DistanceMetersSpecified() As Boolean
            Get
                Return Me.distanceMetersFieldSpecified
            End Get
            Set(value As Boolean)
                Me.distanceMetersFieldSpecified = value
            End Set
        End Property
        '''
        Public Property HeartRateBpm() As HeartRateInBeatsPerMinute_t
            Get
                Return Me.heartRateBpmField
            End Get
            Set(value As HeartRateInBeatsPerMinute_t)
                Me.heartRateBpmField = value
            End Set
        End Property
        '''
        Public Property Cadence() As Byte
            Get
                Return Me.cadenceField
            End Get
            Set(value As Byte)
                Me.cadenceField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property CadenceSpecified() As Boolean
            Get
                Return Me.cadenceFieldSpecified
            End Get
            Set(value As Boolean)
                Me.cadenceFieldSpecified = value
            End Set
        End Property
        '''
        Public Property SensorState() As SensorState_t
            Get
                Return Me.sensorStateField
            End Get
            Set(value As SensorState_t)
                Me.sensorStateField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property SensorStateSpecified() As Boolean
            Get
                Return Me.sensorStateFieldSpecified
            End Get
            Set(value As Boolean)
                Me.sensorStateFieldSpecified = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Position_t
        Private latitudeDegreesField As Double
        Private longitudeDegreesField As Double
        '''
        Public Property LatitudeDegrees() As Double
            Get
                Return Me.latitudeDegreesField
            End Get
            Set(value As Double)
                Me.latitudeDegreesField = value
            End Set
        End Property
        '''
        Public Property LongitudeDegrees() As Double
            Get
                Return Me.longitudeDegreesField
            End Get
            Set(value As Double)
                Me.longitudeDegreesField = value
            End Set
        End Property
    End Class
    '''
     _
    Public Enum SensorState_t
        '''
        Present
        '''
        Absent
    End Enum
    '''
     _
    Partial Public Class Training_t
        Private quickWorkoutResultsField As QuickWorkout_t
        Private planField As Plan_t
        Private virtualPartnerField As Boolean
        '''
        Public Property QuickWorkoutResults() As QuickWorkout_t
            Get
                Return Me.quickWorkoutResultsField
            End Get
            Set(value As QuickWorkout_t)
                Me.quickWorkoutResultsField = value
            End Set
        End Property
        '''
        Public Property Plan() As Plan_t
            Get
                Return Me.planField
            End Get
            Set(value As Plan_t)
                Me.planField = value
            End Set
        End Property
        '''
        _
        Public Property VirtualPartner() As Boolean
            Get
                Return Me.virtualPartnerField
            End Get
            Set(value As Boolean)
                Me.virtualPartnerField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class QuickWorkout_t
        Private totalTimeSecondsField As Double
        Private distanceMetersField As Double
        '''
        Public Property TotalTimeSeconds() As Double
            Get
                Return Me.totalTimeSecondsField
            End Get
            Set(value As Double)
                Me.totalTimeSecondsField = value
            End Set
        End Property
        '''
        Public Property DistanceMeters() As Double
            Get
                Return Me.distanceMetersField
            End Get
            Set(value As Double)
                Me.distanceMetersField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Plan_t
        Private nameField As String
        Private extensionsField As Extensions_t
        Private typeField As TrainingType_t
        Private intervalWorkoutField As Boolean
        '''
        _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property Type() As TrainingType_t
            Get
                Return Me.typeField
            End Get
            Set(value As TrainingType_t)
                Me.typeField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property IntervalWorkout() As Boolean
            Get
                Return Me.intervalWorkoutField
            End Get
            Set(value As Boolean)
                Me.intervalWorkoutField = value
            End Set
        End Property
    End Class
    '''
     _
    Public Enum TrainingType_t
        '''
        Workout
        '''
        Course
    End Enum
    '''
     _
    Partial Public MustInherit Class AbstractSource_t
        Private nameField As String
        '''
        _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
    End Class
    '''
     _
    Public Enum Sport_t
        '''
        Running
        '''
        Biking
        '''
        Other
    End Enum
    '''
     _
    Partial Public Class MultiSportSession_t
        Private idField As Date
        Private firstSportField As FirstSport_t
        Private nextSportField() As NextSport_t
        Private notesField As String
        '''
        Public Property Id() As Date
            Get
                Return Me.idField
            End Get
            Set(value As Date)
                Me.idField = value
            End Set
        End Property
        '''
        Public Property FirstSport() As FirstSport_t
            Get
                Return Me.firstSportField
            End Get
            Set(value As FirstSport_t)
                Me.firstSportField = value
            End Set
        End Property
        '''
        _
        Public Property NextSport() As NextSport_t()
            Get
                Return Me.nextSportField
            End Get
            Set(value As NextSport_t())
                Me.nextSportField = value
            End Set
        End Property
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class FirstSport_t
        Private activityField As Activity_t
        '''
        Public Property Activity() As Activity_t
            Get
                Return Me.activityField
            End Get
            Set(value As Activity_t)
                Me.activityField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class NextSport_t
        Private transitionField As ActivityLap_t
        Private activityField As Activity_t
        '''
        Public Property Transition() As ActivityLap_t
            Get
                Return Me.transitionField
            End Get
            Set(value As ActivityLap_t)
                Me.transitionField = value
            End Set
        End Property
        '''
        Public Property Activity() As Activity_t
            Get
                Return Me.activityField
            End Get
            Set(value As Activity_t)
                Me.activityField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Workout_t
        Private nameField As String
        Private stepField() As AbstractStep_t
        Private scheduledOnField() As Date
        Private notesField As String
        Private creatorField As AbstractSource_t
        Private extensionsField As Extensions_t
        Private sportField As Sport_t
        '''
        _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
        '''
        _
        Public Property [Step]() As AbstractStep_t()
            Get
                Return Me.stepField
            End Get
            Set(value As AbstractStep_t())
                Me.stepField = value
            End Set
        End Property
        '''
        _
        Public Property ScheduledOn() As Date()
            Get
                Return Me.scheduledOnField
            End Get
            Set(value As Date())
                Me.scheduledOnField = value
            End Set
        End Property
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
        '''
        Public Property Creator() As AbstractSource_t
            Get
                Return Me.creatorField
            End Get
            Set(value As AbstractSource_t)
                Me.creatorField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
        '''
        <XmlAttribute()> _
        Public Property Sport() As Sport_t
            Get
                Return Me.sportField
            End Get
            Set(value As Sport_t)
                Me.sportField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public MustInherit Class AbstractStep_t
        Private stepIdField As String
        '''
        _
        Public Property StepId() As String
            Get
                Return Me.stepIdField
            End Get
            Set(value As String)
                Me.stepIdField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Course_t
        Private nameField As String
        Private lapField() As CourseLap_t
        Private trackField()() As Trackpoint_t
        Private notesField As String
        Private coursePointField() As CoursePoint_t
        Private creatorField As AbstractSource_t
        Private extensionsField As Extensions_t
        '''
        _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
        '''
        _
        Public Property Lap() As CourseLap_t()
            Get
                Return Me.lapField
            End Get
            Set(value As CourseLap_t())
                Me.lapField = value
            End Set
        End Property
        '''
        _
        Public Property Track() As Trackpoint_t()()
            Get
                Return Me.trackField
            End Get
            Set(value As Trackpoint_t()())
                Me.trackField = value
            End Set
        End Property
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
        '''
        _
        Public Property CoursePoint() As CoursePoint_t()
            Get
                Return Me.coursePointField
            End Get
            Set(value As CoursePoint_t())
                Me.coursePointField = value
            End Set
        End Property
        '''
        Public Property Creator() As AbstractSource_t
            Get
                Return Me.creatorField
            End Get
            Set(value As AbstractSource_t)
                Me.creatorField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class CourseLap_t
        Private totalTimeSecondsField As Double
        Private distanceMetersField As Double
        Private beginPositionField As Position_t
        Private beginAltitudeMetersField As Double
        Private beginAltitudeMetersFieldSpecified As Boolean
        Private endPositionField As Position_t
        Private endAltitudeMetersField As Double
        Private endAltitudeMetersFieldSpecified As Boolean
        Private averageHeartRateBpmField As HeartRateInBeatsPerMinute_t
        Private maximumHeartRateBpmField As HeartRateInBeatsPerMinute_t
        Private intensityField As Intensity_t
        Private cadenceField As Byte
        Private cadenceFieldSpecified As Boolean
        Private extensionsField As Extensions_t
        '''
        Public Property TotalTimeSeconds() As Double
            Get
                Return Me.totalTimeSecondsField
            End Get
            Set(value As Double)
                Me.totalTimeSecondsField = value
            End Set
        End Property
        '''
        Public Property DistanceMeters() As Double
            Get
                Return Me.distanceMetersField
            End Get
            Set(value As Double)
                Me.distanceMetersField = value
            End Set
        End Property
        '''
        Public Property BeginPosition() As Position_t
            Get
                Return Me.beginPositionField
            End Get
            Set(value As Position_t)
                Me.beginPositionField = value
            End Set
        End Property
        '''
        Public Property BeginAltitudeMeters() As Double
            Get
                Return Me.beginAltitudeMetersField
            End Get
            Set(value As Double)
                Me.beginAltitudeMetersField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property BeginAltitudeMetersSpecified() As Boolean
            Get
                Return Me.beginAltitudeMetersFieldSpecified
            End Get
            Set(value As Boolean)
                Me.beginAltitudeMetersFieldSpecified = value
            End Set
        End Property
        '''
        Public Property EndPosition() As Position_t
            Get
                Return Me.endPositionField
            End Get
            Set(value As Position_t)
                Me.endPositionField = value
            End Set
        End Property
        '''
        Public Property EndAltitudeMeters() As Double
            Get
                Return Me.endAltitudeMetersField
            End Get
            Set(value As Double)
                Me.endAltitudeMetersField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property EndAltitudeMetersSpecified() As Boolean
            Get
                Return Me.endAltitudeMetersFieldSpecified
            End Get
            Set(value As Boolean)
                Me.endAltitudeMetersFieldSpecified = value
            End Set
        End Property
        '''
        Public Property AverageHeartRateBpm() As HeartRateInBeatsPerMinute_t
            Get
                Return Me.averageHeartRateBpmField
            End Get
            Set(value As HeartRateInBeatsPerMinute_t)
                Me.averageHeartRateBpmField = value
            End Set
        End Property
        '''
        Public Property MaximumHeartRateBpm() As HeartRateInBeatsPerMinute_t
            Get
                Return Me.maximumHeartRateBpmField
            End Get
            Set(value As HeartRateInBeatsPerMinute_t)
                Me.maximumHeartRateBpmField = value
            End Set
        End Property
        '''
        Public Property Intensity() As Intensity_t
            Get
                Return Me.intensityField
            End Get
            Set(value As Intensity_t)
                Me.intensityField = value
            End Set
        End Property
        '''
        Public Property Cadence() As Byte
            Get
                Return Me.cadenceField
            End Get
            Set(value As Byte)
                Me.cadenceField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property CadenceSpecified() As Boolean
            Get
                Return Me.cadenceFieldSpecified
            End Get
            Set(value As Boolean)
                Me.cadenceFieldSpecified = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class CoursePoint_t
        Private nameField As String
        Private timeField As Date
        Private positionField As Position_t
        Private altitudeMetersField As Double
        Private altitudeMetersFieldSpecified As Boolean
        Private pointTypeField As CoursePointType_t
        Private notesField As String
        Private extensionsField As Extensions_t
        '''
        _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
        '''
        Public Property Time() As Date
            Get
                Return Me.timeField
            End Get
            Set(value As Date)
                Me.timeField = value
            End Set
        End Property
        '''
        Public Property Position() As Position_t
            Get
                Return Me.positionField
            End Get
            Set(value As Position_t)
                Me.positionField = value
            End Set
        End Property
        '''
        Public Property AltitudeMeters() As Double
            Get
                Return Me.altitudeMetersField
            End Get
            Set(value As Double)
                Me.altitudeMetersField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property AltitudeMetersSpecified() As Boolean
            Get
                Return Me.altitudeMetersFieldSpecified
            End Get
            Set(value As Boolean)
                Me.altitudeMetersFieldSpecified = value
            End Set
        End Property
        '''
        Public Property PointType() As CoursePointType_t
            Get
                Return Me.pointTypeField
            End Get
            Set(value As CoursePointType_t)
                Me.pointTypeField = value
            End Set
        End Property
        '''
        Public Property Notes() As String
            Get
                Return Me.notesField
            End Get
            Set(value As String)
                Me.notesField = value
            End Set
        End Property
        '''
        Public Property Extensions() As Extensions_t
            Get
                Return Me.extensionsField
            End Get
            Set(value As Extensions_t)
                Me.extensionsField = value
            End Set
        End Property
    End Class
    '''
     _
    Public Enum CoursePointType_t
        '''
        Generic
        '''
        Summit
        '''
        Valley
        '''
        Water
        '''
        Food
        '''
        Danger
        '''
        Left
        '''
        Right
        '''
        Straight
        '''
        _
        FirstAid
        '''
        _
        Item4thCategory
        '''
        _
        Item3rdCategory
        '''
        _
        Item2ndCategory
        '''
        _
        Item1stCategory
        '''
        _
        HorsCategory
        '''
        Sprint
    End Enum
    '''
     _
    Partial Public Class WorkoutList_t
        Private workoutField() As Workout_t
        '''
        _
        Public Property Workout() As Workout_t()
            Get
                Return Me.workoutField
            End Get
            Set(value As Workout_t())
                Me.workoutField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class CourseList_t
        Private courseField() As Course_t
        '''
        _
        Public Property Course() As Course_t()
            Get
                Return Me.courseField
            End Get
            Set(value As Course_t())
                Me.courseField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Device_t
        Inherits AbstractSource_t
        Private unitIdField As UInteger
        Private productIDField As UShort
        Private versionField As Version_t
        '''
        Public Property UnitId() As UInteger
            Get
                Return Me.unitIdField
            End Get
            Set(value As UInteger)
                Me.unitIdField = value
            End Set
        End Property
        '''
        Public Property ProductID() As UShort
            Get
                Return Me.productIDField
            End Get
            Set(value As UShort)
                Me.productIDField = value
            End Set
        End Property
        '''
        Public Property Version() As Version_t
            Get
                Return Me.versionField
            End Get
            Set(value As Version_t)
                Me.versionField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Version_t
        Private versionMajorField As UShort
        Private versionMinorField As UShort
        Private buildMajorField As UShort
        Private buildMajorFieldSpecified As Boolean
        Private buildMinorField As UShort
        Private buildMinorFieldSpecified As Boolean
        '''
        Public Property VersionMajor() As UShort
            Get
                Return Me.versionMajorField
            End Get
            Set(value As UShort)
                Me.versionMajorField = value
            End Set
        End Property
        '''
        Public Property VersionMinor() As UShort
            Get
                Return Me.versionMinorField
            End Get
            Set(value As UShort)
                Me.versionMinorField = value
            End Set
        End Property
        '''
        Public Property BuildMajor() As UShort
            Get
                Return Me.buildMajorField
            End Get
            Set(value As UShort)
                Me.buildMajorField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property BuildMajorSpecified() As Boolean
            Get
                Return Me.buildMajorFieldSpecified
            End Get
            Set(value As Boolean)
                Me.buildMajorFieldSpecified = value
            End Set
        End Property
        '''
        Public Property BuildMinor() As UShort
            Get
                Return Me.buildMinorField
            End Get
            Set(value As UShort)
                Me.buildMinorField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property BuildMinorSpecified() As Boolean
            Get
                Return Me.buildMinorFieldSpecified
            End Get
            Set(value As Boolean)
                Me.buildMinorFieldSpecified = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Application_t
        Inherits AbstractSource_t
        Private buildField As Build_t
        Private langIDField As String
        Private partNumberField As String
        '''
        Public Property Build() As Build_t
            Get
                Return Me.buildField
            End Get
            Set(value As Build_t)
                Me.buildField = value
            End Set
        End Property
        '''
        _
        Public Property LangID() As String
            Get
                Return Me.langIDField
            End Get
            Set(value As String)
                Me.langIDField = value
            End Set
        End Property
        '''
        _
        Public Property PartNumber() As String
            Get
                Return Me.partNumberField
            End Get
            Set(value As String)
                Me.partNumberField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Build_t
        Private versionField As Version_t
        Private typeField As BuildType_t
        Private typeFieldSpecified As Boolean
        Private timeField As String
        Private builderField As String
        '''
        Public Property Version() As Version_t
            Get
                Return Me.versionField
            End Get
            Set(value As Version_t)
                Me.versionField = value
            End Set
        End Property
        '''
        Public Property Type() As BuildType_t
            Get
                Return Me.typeField
            End Get
            Set(value As BuildType_t)
                Me.typeField = value
            End Set
        End Property
        '''
        <XmlIgnore()> _
        Public Property TypeSpecified() As Boolean
            Get
                Return Me.typeFieldSpecified
            End Get
            Set(value As Boolean)
                Me.typeFieldSpecified = value
            End Set
        End Property
        '''
        _
        Public Property Time() As String
            Get
                Return Me.timeField
            End Get
            Set(value As String)
                Me.timeField = value
            End Set
        End Property
        '''
        _
        Public Property Builder() As String
            Get
                Return Me.builderField
            End Get
            Set(value As String)
                Me.builderField = value
            End Set
        End Property
    End Class
    '''
     _
    Public Enum BuildType_t
        '''
        Internal
        '''
        Alpha
        '''
        Beta
        '''
        Release
    End Enum
    '''
     _
    Partial Public Class Track_t
        Private trackpointField() As Trackpoint_t
        '''
        <XmlElement()> _
        Public Property Trackpoint() As Trackpoint_t()
            Get
                Return Me.trackpointField
            End Get
            Set(value As Trackpoint_t())
                Me.trackpointField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Repeat_t
        Inherits AbstractStep_t
        Private repetitionsField As String
        Private childField() As AbstractStep_t
        '''
        _
        Public Property Repetitions() As String
            Get
                Return Me.repetitionsField
            End Get
            Set(value As String)
                Me.repetitionsField = value
            End Set
        End Property
        '''
        _
        Public Property Child() As AbstractStep_t()
            Get
                Return Me.childField
            End Get
            Set(value As AbstractStep_t())
                Me.childField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Step_t
        Inherits AbstractStep_t
        Private nameField As String
        Private durationField As Duration_t
        Private intensityField As Intensity_t
        Private targetField As Target_t
        '''
        _
        Public Property Name() As String
            Get
                Return Me.nameField
            End Get
            Set(value As String)
                Me.nameField = value
            End Set
        End Property
        '''
        Public Property Duration() As Duration_t
            Get
                Return Me.durationField
            End Get
            Set(value As Duration_t)
                Me.durationField = value
            End Set
        End Property
        '''
        Public Property Intensity() As Intensity_t
            Get
                Return Me.intensityField
            End Get
            Set(value As Intensity_t)
                Me.intensityField = value
            End Set
        End Property
        '''
        Public Property Target() As Target_t
            Get
                Return Me.targetField
            End Get
            Set(value As Target_t)
                Me.targetField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public MustInherit Class Duration_t
    End Class
    '''
     _
    Partial Public MustInherit Class Target_t
    End Class
    '''
     _
    Partial Public Class Time_t
        Inherits Duration_t
        Private secondsField As UShort
        '''
        Public Property Seconds() As UShort
            Get
                Return Me.secondsField
            End Get
            Set(value As UShort)
                Me.secondsField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Distance_t
        Inherits Duration_t
        Private metersField As UShort
        '''
        Public Property Meters() As UShort
            Get
                Return Me.metersField
            End Get
            Set(value As UShort)
                Me.metersField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class HeartRateAbove_t
        Inherits Duration_t
        Private heartRateField As HeartRateValue_t
        '''
        Public Property HeartRate() As HeartRateValue_t
            Get
                Return Me.heartRateField
            End Get
            Set(value As HeartRateValue_t)
                Me.heartRateField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class HeartRateBelow_t
        Inherits Duration_t
        Private heartRateField As HeartRateValue_t
        '''
        Public Property HeartRate() As HeartRateValue_t
            Get
                Return Me.heartRateField
            End Get
            Set(value As HeartRateValue_t)
                Me.heartRateField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class CaloriesBurned_t
        Inherits Duration_t
        Private caloriesField As UShort
        '''
        Public Property Calories() As UShort
            Get
                Return Me.caloriesField
            End Get
            Set(value As UShort)
                Me.caloriesField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class UserInitiated_t
        Inherits Duration_t
    End Class
    '''
     _
    Partial Public Class Speed_t
        Inherits Target_t
        Private speedZoneField As Zone_t
        '''
        Public Property SpeedZone() As Zone_t
            Get
                Return Me.speedZoneField
            End Get
            Set(value As Zone_t)
                Me.speedZoneField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public MustInherit Class Zone_t
    End Class
    '''
     _
    Partial Public Class HeartRate_t
        Inherits Target_t
        Private heartRateZoneField As Zone_t
        '''
        Public Property HeartRateZone() As Zone_t
            Get
                Return Me.heartRateZoneField
            End Get
            Set(value As Zone_t)
                Me.heartRateZoneField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class Cadence_t
        Inherits Target_t
        Private lowField As Double
        Private highField As Double
        '''
        Public Property Low() As Double
            Get
                Return Me.lowField
            End Get
            Set(value As Double)
                Me.lowField = value
            End Set
        End Property
        '''
        Public Property High() As Double
            Get
                Return Me.highField
            End Get
            Set(value As Double)
                Me.highField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class None_t
        Inherits Target_t
    End Class
    '''
     _
    Partial Public Class PredefinedSpeedZone_t
        Inherits Zone_t
        Private numberField As String
        '''
        _
        Public Property Number() As String
            Get
                Return Me.numberField
            End Get
            Set(value As String)
                Me.numberField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class CustomSpeedZone_t
        Inherits Zone_t
        Private viewAsField As SpeedType_t
        Private lowInMetersPerSecondField As Double
        Private highInMetersPerSecondField As Double
        '''
        Public Property ViewAs() As SpeedType_t
            Get
                Return Me.viewAsField
            End Get
            Set(value As SpeedType_t)
                Me.viewAsField = value
            End Set
        End Property
        '''
        Public Property LowInMetersPerSecond() As Double
            Get
                Return Me.lowInMetersPerSecondField
            End Get
            Set(value As Double)
                Me.lowInMetersPerSecondField = value
            End Set
        End Property
        '''
        Public Property HighInMetersPerSecond() As Double
            Get
                Return Me.highInMetersPerSecondField
            End Get
            Set(value As Double)
                Me.highInMetersPerSecondField = value
            End Set
        End Property
    End Class
    '''
     _
    Public Enum SpeedType_t
        '''
        Pace
        '''
        Speed
    End Enum
    '''
     _
    Partial Public Class PredefinedHeartRateZone_t
        Inherits Zone_t
        Private numberField As String
        '''
        _
        Public Property Number() As String
            Get
                Return Me.numberField
            End Get
            Set(value As String)
                Me.numberField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class CustomHeartRateZone_t
        Inherits Zone_t
        Private lowField As HeartRateValue_t
        Private highField As HeartRateValue_t
        '''
        Public Property Low() As HeartRateValue_t
            Get
                Return Me.lowField
            End Get
            Set(value As HeartRateValue_t)
                Me.lowField = value
            End Set
        End Property
        '''
        Public Property High() As HeartRateValue_t
            Get
                Return Me.highField
            End Get
            Set(value As HeartRateValue_t)
                Me.highField = value
            End Set
        End Property
    End Class
    '''
     _
    Partial Public Class HeartRateAsPercentOfMax_t
        Inherits HeartRateValue_t
        Private valueField As Byte
        '''
        Public Property Value() As Byte
            Get
                Return Me.valueField
            End Get
            Set(value As Byte)
                Me.valueField = value
            End Set
        End Property
    End Class
    '''
     _
    Public Enum Gender_t
        '''
        Male
        '''
        Female
    End Enum
End Namespace
